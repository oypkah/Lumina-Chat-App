using LCA_Common.Client.Enums;
using LCA_Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.Friendship
{
    public class FriendshipRequest : BaseDto
    {
        public FriendShipStatus FriendShipStatus { get; set; }

        public int UserOneId { get; set; }

        public int UserTwoId { get; set; }

        public int ActionUserId { get; set; }
    }
}
