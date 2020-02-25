using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_18___Coffee_Shop.Models
{
    public class RegisterUser
    {
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Invalid! Username length must be between 2-20 characters!")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9{5,30}]+@[a-zA-A0-9{5,10}]+\.[a-zA-Z0-9{2,3}]+$", ErrorMessage = "Not a valid email!")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"\b[A-z0-9]{5,10}\b+$", ErrorMessage = "Invalid Entry!")]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }

        public int Age { get; set; }

        [Required]
        [RegularExpression(@"^\b\d{3}-\d{3}-\d{4}\b$", ErrorMessage = "Incorrect format of phone number!")]
        public string PhoneNumber { get; set; }
    }
}
