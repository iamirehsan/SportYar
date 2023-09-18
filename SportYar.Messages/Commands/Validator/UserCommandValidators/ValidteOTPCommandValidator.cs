using FluentValidation;
using SportYar.Messages.Commands.UserCommands;

namespace SportYar.Messages.Commands.Validator.UserCommandValidators
{
    public class ValidteOTPCommandValidator : AbstractValidator<ValidteOTPCommand>

    {
        public ValidteOTPCommandValidator()
        {
            RuleFor(x => x.OTP).NotEmpty().WithMessage("کد یک بار مصرف نمیتواند خالی باشد");
            RuleFor(x => x.OTPKey).NotEmpty().WithMessage("ایدی کد یک بار مصرف نمیتواند خالی باشد. ");
        }
    }

}
