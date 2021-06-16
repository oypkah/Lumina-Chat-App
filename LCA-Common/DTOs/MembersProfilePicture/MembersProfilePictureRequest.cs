using LCA_Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.MembersProfilePicture
{
    public class MembersProfilePictureRequest : BaseDto
    {
        public string Filename { get; set; }
        public string Filepath { get; set; }

        public int MemberId { get; set; }
    }
}
