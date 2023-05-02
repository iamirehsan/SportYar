using System;
using System.ComponentModel.DataAnnotations;

public class GreaterOtEqualThanPresentDate : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null)
        {
            return true;
        }

        if (value is DateTime date)
        {
            return date.Date >= DateTime.Today;
        }

        return false;
    }

    public override string FormatErrorMessage(string name)
    {
        return $"{name} must be greater than or equal to today's date.";
    }
}
