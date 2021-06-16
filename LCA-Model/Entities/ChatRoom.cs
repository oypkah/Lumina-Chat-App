using LCA_Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Entities
{
    public class ChatRoom : CoreEntity
    {
        public ChatRoom()
        {
            Messages = new HashSet<Message>();
        }

        public int FriendshipId { get; set; }
        public Friendship Friendship { get; set; }

        public string LastMessage { get; set; }

        public ICollection<Message> Messages { get; set; }

    }
}
