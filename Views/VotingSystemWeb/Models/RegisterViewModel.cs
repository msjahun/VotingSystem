using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VotingSystemWeb.Models
{
    public class RegisterViewModel
    {
        [Required,  MaxLength(256)]
        public string UserName { get; set; }

        [Required, MaxLength(256), Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Required, MaxLength(256), Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required, MaxLength(10), Display(Name = "Student number")]
        public string CitizenshipNumber { get; set; }

        [Required, MinLength(6), MaxLength(50), DataType(DataType.Password), Display(Name = "Password")]
        public string Password { get; set; }

        [Required, MinLength(6), MaxLength(50), DataType(DataType.Password), Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password does not match the confirmation password.")]
        public string ConfirmPassword { get; set; }
    }
}
