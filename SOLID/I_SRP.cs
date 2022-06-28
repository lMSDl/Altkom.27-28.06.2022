﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class Validators
    { 
        public static bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidatePassword(string password)
        {
            return password.Length > 20;
        }
    }

    //public class User
    //{
    //    public string UserName { get; set; }
    //    public string Password { get; set; }
    //    public string Email { get; set; }

    //    public bool ValidateEmail()
    //    {
    //        try
    //        {
    //            var addr = new System.Net.Mail.MailAddress(Email);
    //            return addr.Address == Email;
    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //    }
    //}
}
