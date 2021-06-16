using LCA_Core.Entity;
using LCA_Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Entities
{
    public class Friendship : CoreEntity
    {
        public FriendShipStatus FriendShipStatus { get; set; }

        public int UserOneId { get; set; }
        public Member UserOne { get; set; }

        public int UserTwoId { get; set; }
        public Member UserTwo { get; set; }

        public int ActionUserId { get; set; }
        public Member ActionUser { get; set; }

        public int ChatRoomId { get; set; }
        public ChatRoom ChatRoom { get; set; }
    }
}
