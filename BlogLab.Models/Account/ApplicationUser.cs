﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLab.Models.Account
{
    class ApplicationUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public string Token { get; set; }

    }
}
