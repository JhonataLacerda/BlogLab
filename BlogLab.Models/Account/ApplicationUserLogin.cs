using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlogLab.Models.Account
{
    class ApplicationUserLogin
    {
        [Required(ErrorMessage ="Username is required!")]
        [MinLength(5, ErrorMessage ="Must be  5-20 characteres")]
        [MaxLength(20,ErrorMessage ="Must be  5-20 characteres")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Passowrd is required!")]
        [MinLength(10, ErrorMessage = "Must be  10-50 characteres")]
        [MaxLength(50, ErrorMessage = "Must be  10-50 characteres")]
        public string Password { get; set; }
        
    }
}
