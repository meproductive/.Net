using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingProject.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a surname")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter an email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter repassword")]
        public string RePassword { get; set; }
        [Required(ErrorMessage = "Please enter a phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter an adress")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Please enter birthdate")]
        public string Birthdate { get; set; }
    }
}