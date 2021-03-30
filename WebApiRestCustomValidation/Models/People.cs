using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiRestCustomValidation.Models
{
    public class People
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string NickName { get; set; }
    }
}
