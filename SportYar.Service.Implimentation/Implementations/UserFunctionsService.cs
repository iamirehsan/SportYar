using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Mail;
using System.Net;
using System.Security.Claims;
using System.Text;
using SportYar.Service.Interfaces;
using SportYar.Domain.Entites;
using SportYar.Repository;
using SportYar.Messages.Commands.UserCommands;
using SportYar.Infrastructure.Base;
using StackExchange.Redis;
using SportYar.Infrastructure.StaticMethods;

namespace SportYar.Service.Implimentation.Implementations
{

    public class UserFunctionsService : IUserFunctionsService
    {
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDatabase _redisDb;

        public UserFunctionsService(UserManager<User> userManager, IConfiguration configuration, IUnitOfWork unitOfWork, IRedisService redisService)
        {
            _userManager = userManager;
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _redisDb = redisService.GetDatabase();
        }
        public async Task<Guid> Signup(SignupCommand cmd)
        {
            await ValidateUserCreation(cmd.NationalId, cmd.Email, cmd.PhoneNumber);
            var user = new User(cmd.UserName, cmd.FirstName, cmd.LastName, cmd.Email, cmd.PhoneNumber, cmd.DateOfBirth, cmd.NationalId, cmd.RegionId);
            user.BanksCardsNumber = cmd.BanksCardsNumber;
            var result = await _userManager.CreateAsync(user, cmd.Password);

            if (!result.Succeeded)
            {
                throw new ManagedException(result.Errors.Select(x => x.Description));
            }

            return user.Id;
        }
        public async Task<string> Signin(SigninCommand cmd)
        {
            var user = await _userManager.FindByNameAsync(cmd.UserName);
            if (user is null)
                throw new ManagedException("نام کاربری یا رمز عبور اشتباه است");
            if (await _userManager.CheckPasswordAsync(user, cmd.Password) == false)
                throw new ManagedException("نام کاربری یا رمز عبور اشتباه است");
            return CreateToken(user);
        }
        public async Task UpdateUser(UpdateUserCommand cmd, Guid userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == userId);
            await ValidateUserCreation(cmd.NationalId, cmd.Email, cmd.PhoneNumber);
            user.FirstName = cmd.FirstName;
            user.LastName = cmd.LastName;
            user.Email = cmd.Email;
            user.PhoneNumber = cmd.PhoneNumber;
            user.DateOfBirth = cmd.DateOfBirth;
            user.NationalId = cmd.NationalId;
            user.RegionId = cmd.RegionId;
            user.BanksCardsNumber = cmd.BanksCardNumber;
            await _unitOfWork.CommitAsync();

        }
        public async Task UpdatePassword(UpdatePasswordCommand cmd, Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            var result = await _userManager.ChangePasswordAsync(user, cmd.CurrentPassword, cmd.NewPassword);
            if (!result.Succeeded)
                throw new ManagedException(result.Errors.Select(x => x.Description));

        }
        public async Task ValidateOTP(ValidteOTPCommand cmd)
        {
            var otp = await _redisDb.StringGetAsync(cmd.OTPKey);
            if (otp == string.Empty)
                throw new ManagedException("کد وارد شده منقضی شده است.");
            if (otp != cmd.OTP)
                throw new ManagedException("کد وارد شده اشتباه است.");
        }
        public async Task<string> SendOTPByEmailForForgetPassword(string UserNameOrEmial)
        {
            var user = await _userManager.FindByNameAsync(UserNameOrEmial);
            if (user is null)
                user = await _userManager.FindByEmailAsync(UserNameOrEmial);
            if (user is null)
                throw new ManagedException("نام کاربری یا ایمیل وارد شده در سامانه ثبت نشده است. ");
            var id = Guid.NewGuid().ToString();
            var otp = CodeGenerator.RandomCode(6, new Random());
            var emailmessage = $"{_configuration["Email:OTPBody"]}\n{otp}";
            EmailSender(user.Email, _configuration["Email:EmailAdrees"], _configuration["Email:OTPSubject"], emailmessage, _configuration["Email:SmtpServer"], int.Parse(_configuration["Email:SmtpPort"]), _configuration["Email:EmailPassword"]);
            await _redisDb.StringSetAsync(id, otp, TimeSpan.FromMinutes(10));
            return id;
        }
        public async Task RestartPassword(RestartPasswordCommand cmd)
        {
            var user = await _userManager.FindByEmailAsync(cmd.UserNameOrPassword) is null ? await _userManager.FindByNameAsync(cmd.UserNameOrPassword) : await _userManager.FindByEmailAsync(cmd.UserNameOrPassword);
            if (user is null)
                throw new ManagedException("نام کاربری یا ایمیل اشتباه میباشد. ");
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, cmd.NewPassword);
            if (!result.Succeeded)
                throw new ManagedException(result.Errors.Select(x => x.Description));
        }
        private string EmailBodyMaker(string message)
        {
            var body = new StringBuilder();

            body.Append("<html><head></head><body style=\"direction: rtl\">");
            body.Append("<div style='font-family:tahoma;font-size:14px;color:black;'><br>");
            body.Append(message);
            body.Append("</div><br>");
            body.Append("</body></html>");

            return body.ToString();
        }

        private async Task ValidateUserCreation(string nationalId, string email, string PhoneNumber)
        {
            if (await _userManager.Users.AnyAsync(x => x.NationalId == nationalId))
                throw new ManagedException("کد ملی وارد شده در سامانه ثبت شده است. ");
            if (await _userManager.Users.AnyAsync(x => x.Email == email))
                throw new ManagedException("ایمیل وارد شده در سامانه ثبت شده است. ");
            if (await _userManager.Users.AnyAsync(x => x.PhoneNumber == PhoneNumber))
                throw new ManagedException("شماره موبایل وارد شده در سامانه ثبت شده است. ");
        }
        private string CreateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim("userName" , user.UserName),
            new Claim("userId" , user.Id.ToString()),
            new Claim("iss",_configuration["Jwt:Issuer"] ),
               new Claim( "aud" , _configuration["Jwt:Audience"] )
                    // Add additional claims as desired
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        private void EmailSender(string toEmail, string fromEmail, string subject, string body, string smtpServer, int smtpPort, string senderPassword)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromEmail);
            message.To.Add(toEmail);
            message.Subject = subject;
            message.Body = EmailBodyMaker(body);
            message.IsBodyHtml = true;

            SmtpClient client = new SmtpClient(smtpServer, smtpPort);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(fromEmail, senderPassword);
            client.Send(message);

        }


    }
}
