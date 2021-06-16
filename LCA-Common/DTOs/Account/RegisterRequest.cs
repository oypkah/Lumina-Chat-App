using System;
using System.Collections.Generic;
using System.Text;
using LCA_Common.Client.Enums;

namespace LCA_Common.DTOs.Account
{
    public class RegisterRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; } = Role.User;
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string About { get; set; } = "Hi there!";
    }
}
