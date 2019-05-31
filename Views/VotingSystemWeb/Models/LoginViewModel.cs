using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VotingSystemWeb.Models
{
    public class LoginViewModel
    {
        [Required]
      
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
