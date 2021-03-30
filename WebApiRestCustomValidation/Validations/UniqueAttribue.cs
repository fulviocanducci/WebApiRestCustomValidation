using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WebApiRestCustomValidation.Models;
using WebApiRestCustomValidation.Services;

namespace WebApiRestCustomValidation.Validations
{
    public class UniqueAttribute : ValidationAttribute
    {
        public UniqueAttribute()
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DatabaseService service = validationContext
                .GetService(typeof(DatabaseService)) as DatabaseService;
            
            People people = service
                    .People
                    .AsNoTracking()
                    .FirstOrDefault(x => x.NickName == value.ToString());

            People request = validationContext.ObjectInstance as People;

            if (people != null)
            {
                if (people.Id == request.Id)
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult("Nick Name already existing");
            }

            return ValidationResult.Success;
        }
    }
}
