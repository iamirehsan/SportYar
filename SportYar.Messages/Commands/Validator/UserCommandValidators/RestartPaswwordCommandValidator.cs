using FluentValidation;
using SportYar.Messages.Commands.UserCommands;

namespace SportYar.Messages.Commands.Validator.UserCommandValidators
{
    public class RestartPaswwordCommandValidator : AbstractValidator<RestartPasswordCommand>
    {
        public RestartPaswwordCommandValidator()
        {
            RuleFor(x => x.UserNameOrPassword).NotEmpty().WithMessage("ایمیل یا نام کاربری نمیتواند خالی باشد. ");
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("رمز جدید نمیتواند خالی باشد. ");
        }
    }
}
