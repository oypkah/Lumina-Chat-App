using LCA_Common.Client.Enums;
using LCA_Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.Member
{
    public class MemberRequest : BaseDto
    {
        public string ConnectionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string About { get; set; }
        public MemberStatus MemberStatus { get; set; }
        public IsMemberTypingStatus IsMemberTypingStatus { get; set; } 

        public DateTime LastLoginDate { get; set; }
        public DateTime LastLogoutDate { get; set; }

        public int ProfilePicId { get; set; }
    }
}
