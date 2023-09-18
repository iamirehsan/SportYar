using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportYar.Base;
using SportYar.Infrastructure.Base;
using SportYar.Messages.Commands.UserCommands;
using SportYar.Service.Interfaces;

namespace SportYar.Controllers
{
    [Route("api/auth/[controller]")]
    [ApiController]
    public class UserController : ApiControllerBase
    {
        private readonly IServiceHolder _serviceHolder;

        public UserController(IServiceHolder serviceHolder)
        {
            _serviceHolder = serviceHolder;
        }
        [HttpGet]
        public bool Get()
        {
            return true;
        }
        [AllowAnonymous]
        [HttpPost("Signin")]
        public async Task<IActionResult> Signin(SigninCommand cmd)
        {
            try
            {
                var result = await _serviceHolder.UserFunctionsService.Signin(cmd);
                return Ok(new ResponseMessage("ورود کاربر با موفقیت صورت گرفت. ", result, 1));

            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.ErrorMessage);
            }
        }
        [AllowAnonymous]
        [HttpPost("Signup")]
        public async Task<IActionResult> Signup(SignupCommand cmd)
        {
            try
            {
                var result = await _serviceHolder.UserFunctionsService.Signup(cmd);
                return Ok(new ResponseMessage("ثبت نام با موفقیت صورت گرفت.", new { Id = result }, 1));

            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.ErrorMessage);
            }
        }
        [HttpPost("UpdatePassword")]
        public async Task<IActionResult> UpdatePassword(UpdatePasswordCommand cmd)
        {
            try
            {
                await _serviceHolder.UserFunctionsService.UpdatePassword(cmd, UserId);
                return Ok(new ResponseMessage("رمز کاربر با موفقیت تغییر کرد."));

            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.ErrorMessage);
            }
        }
        [HttpPost("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand cmd)
        {
            try
            {
                await _serviceHolder.UserFunctionsService.UpdateUser(cmd, UserId);
                return Ok(new ResponseMessage("اطلاعات کاربر با موفقیت تغییر کرد."));

            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.ErrorMessage);
            }
        }
        [AllowAnonymous]
        [HttpPost("SendOTPByEmailForForgetPassword/{userNameOrPassword}")]
        public async Task<IActionResult> SendOTPByEmailForForgetPassword(string userNameOrPassword)
        {
            try
            {
                var result = await _serviceHolder.UserFunctionsService.SendOTPByEmailForForgetPassword(userNameOrPassword);
                return Ok(new ResponseMessage("رمز یک بار مصرف ارسال گردید.", result, 1));

            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.ErrorMessage);
            }
        }
        [AllowAnonymous]
        [HttpPost("ValidteOTP")]
        public async Task<IActionResult> ValidteOTPAndChangePassword(ValidteOTPCommand cmd)
        {
            try
            {
                await _serviceHolder.UserFunctionsService.ValidateOTP(cmd);
                return Ok(new ResponseMessage("رمز یکبار مصرف بررسی شد."));

            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.ErrorMessage);
            }
        }
        [AllowAnonymous]
        [HttpPost("RestartPassword")]
        public async Task<IActionResult> RestartPassword(RestartPasswordCommand cmd)
        {
            try
            {
                await _serviceHolder.UserFunctionsService.RestartPassword(cmd);
                return Ok(new ResponseMessage("رمز عبور با موفقیت بازیابی شد."));

            }
            catch (ManagedException ex)
            {

                return BadRequest(ex.ErrorMessage);
            }
        }
    }
}
