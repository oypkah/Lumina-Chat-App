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
            SendingMessages = new HashSet<Message>();
            ReceivingMessages = new HashSet<Message>();

            FirstFriendships = new HashSet<Friendship>();
            SecondFriendships = new HashSet<Friendship>();
            ActionFriendships = new HashSet<Friendship>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string About { get; set; }

        public DateTime LastLoginDate { get; set; }
        public DateTime LastLogoutDate { get; set; }

        public int ProfilePicId { get; set; }
        public MembersProfilePicture MembersProfilePicture { get; set; }


        public ICollection<Message> SendingMessages { get; set; }
        public ICollection<Message> ReceivingMessages { get; set; }


        public ICollection<Friendship> FirstFriendships { get; set; }
        public ICollection<Friendship> SecondFriendships { get; set; }
        public ICollection<Friendship> ActionFriendships { get; set; }
    }
}
