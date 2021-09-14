using System;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationDemo.Attributes.CustomValidations
{
    public class IsEmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object pValue)
        {
            return new RegularExpressionAttribute(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$")
                .IsValid(Convert
                         .ToString(pValue)
                         .Trim());
        }
    }
}