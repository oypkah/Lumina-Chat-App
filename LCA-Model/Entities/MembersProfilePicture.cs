using LCA_Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Entities
{
    public class MembersProfilePicture : CoreEntity
    {
        public string Filename { get; set; }
        public string Filepath { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}
