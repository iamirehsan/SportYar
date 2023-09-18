using SportYar.Messages.Commands.UserCommands;

namespace SportYar.Service.Interfaces
{
    public interface IUserFunctionsService
    {
        public Task<Guid> Signup(SignupCommand cmd);
        public Task<string> Signin(SigninCommand cmd);

        public Task UpdateUser(UpdateUserCommand cmd, Guid userId);

        public Task UpdatePassword(UpdatePasswordCommand cmd, Guid userId);

        public Task<string> SendOTPByEmailForForgetPassword(string UserNameOrEmial);

        public Task ValidateOTP(ValidteOTPCommand cmd);
        public Task RestartPassword(RestartPasswordCommand cmd);
    }
}
