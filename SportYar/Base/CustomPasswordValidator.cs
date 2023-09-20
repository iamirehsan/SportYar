using Microsoft.AspNetCore.Identity;
 
public class CustomErrorDescriber : IdentityErrorDescriber
{
    public override IdentityError PasswordRequiresDigit()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresDigit),
            Description = "رمز عبور باید شامل اعداد باشد. "
        };
    }
    public override IdentityError PasswordRequiresUpper()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresUpper),
            Description = "رمز عبور باید شامل حروف بزرگ باشد. "
        };
    }
    public override IdentityError PasswordRequiresLower()
    {
        return new IdentityError
        {
            Code = nameof(PasswordRequiresLower),
            Description = "رمز عبور باید شامل حروف کوچک باشد. "
        };
    }
    public override IdentityError PasswordTooShort(int length)
    {
        return new IdentityError
        {
            Code = nameof(PasswordTooShort),
            Description = $"طول رمز عبور باید حداقل {length} کاراکتر باشد."
        };
    }
    public override IdentityError DuplicateUserName(string userName)
    {
        return new IdentityError
        {
            Code = nameof(DuplicateUserName),
            Description =  $"{userName} قبلا استفاده شده است."
        };
    }
    public virtual IdentityError InvalidEmail(string? email)
    {
        return new IdentityError
        {
            Code = nameof(InvalidEmail),
            Description = "فرمت پست الکترونیکی وارد شده درست نمیباشد. "
        };
    }
    public virtual IdentityError DuplicateEmail(string email)
    {
        return new IdentityError
        {
            Code = nameof(DuplicateEmail),
            Description = $"{email} قبلا استفاده شده است."
        };
    }


    // Add additional overrides for other password validation error messages here
}

