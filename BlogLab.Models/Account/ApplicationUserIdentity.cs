using System;
using System.Collections.Generic;
using System.Text;


namespace BlogLab.Models.Account
{
    public class ApplicationUserIdentity
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string NormalizedUserName { get; set; }
        public string  Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string Fullname { get; set; }
        public string PasswordHash { get; set; }
    }
}
