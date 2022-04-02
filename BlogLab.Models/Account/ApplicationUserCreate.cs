using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlogLab.Models.Account
{
    class ApplicationUserCreate : ApplicationUserLogin
    {
        [MinLength(10, ErrorMessage = "Must be  10-30 characteres")]
        [MaxLength(30, ErrorMessage = "Must be  10-30 characteres")]
        public string Fullname { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        [MinLength(30, ErrorMessage = "Can be at most 30 characteres")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }
    }
}
