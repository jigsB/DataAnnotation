using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCPracticeDataAnnotations.CustomAttributes
{
    public class AgeValidation : ValidationAttribute
    {
        private readonly int _age;
        public AgeValidation(int age)
        {
            _age = age;
        }
        protected override ValidationResult  IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return ValidationResult.Success;
            int age = Convert.ToInt32(value);
            return age > _age
                ? new ValidationResult("age is bigger!")
                : ValidationResult.Success;

         //   return ValidationResult.Success;
        }
    }
}
