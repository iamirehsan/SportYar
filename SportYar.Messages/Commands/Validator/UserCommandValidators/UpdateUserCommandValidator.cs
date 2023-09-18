using FluentValidation;
using SportYar.Messages.Commands.UserCommands;

namespace DynamicAuth.Messages.Commands.Validator;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>

{
    public UpdateUserCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("نام کاربر نمیتواند خالی باشد");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("نام خانوادگی کارربر نمیتواند خالی باشد");
        RuleFor(x => x.DateOfBirth).LessThan(DateTime.Now).WithMessage("تاریخ تولد باید کمتر از تاریخ حال باشد. ");
    }
}
