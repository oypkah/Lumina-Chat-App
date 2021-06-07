using LCA_Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Entities
{
    public class Member : CoreEntity
    {
        public Member()
        {
            Messages = new HashSet<Message>();
            Friendships = new HashSet<Friendship>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string About { get; set; }

        public DateTime LastLoginDate { get; set; }

        public int PrfilePicId { get; set; }
        public MembersProfilePicture MembersProfilePicture { get; set; }


        public ICollection<Message> Messages { get; set; }
        public ICollection<Friendship> Friendships { get; set; }
    }
}
