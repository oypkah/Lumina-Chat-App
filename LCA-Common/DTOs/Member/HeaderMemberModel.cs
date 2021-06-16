using LCA_Common.Client.Enums;
using LCA_Common.DTOs.Base;
using LCA_Common.DTOs.MembersProfilePicture;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.Member
{
    public class HeaderMemberModel : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string About { get; set; }

        public DateTime LastLoginDate { get; set; }
        public DateTime LastLogoutDate { get; set; }
        public MemberStatus MemberStatus { get; set; }

        public int ProfilePicId { get; set; }
        public MembersProfilePictureResponse MembersProfilePicture { get; set; }
    }
}
