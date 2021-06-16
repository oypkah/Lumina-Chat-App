using LCA_Common.DTOs.Base;
using LCA_Common.DTOs.Member;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.MembersProfilePicture
{
    public class MembersProfilePictureResponse : BaseDto
    {
        public string Filename { get; set; }
        public string Filepath { get; set; }

        public int Id { get; set; }
        //public MemberResponse Member { get; set; }
    }
}
