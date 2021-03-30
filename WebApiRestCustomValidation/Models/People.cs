using System;
using System.ComponentModel.DataAnnotations;
using WebApiRestCustomValidation.Validations;

namespace WebApiRestCustomValidation.Models
{
    public class People
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Unique]
        public string NickName { get; set; }
    }
}
