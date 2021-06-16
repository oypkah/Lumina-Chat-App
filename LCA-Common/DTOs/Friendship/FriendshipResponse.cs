using LCA_Common.Client.Enums;
using LCA_Common.DTOs.Base;
using LCA_Common.DTOs.Member;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.Friendship
{
    public class FriendshipResponse : BaseDto
    {
        public FriendShipStatus FriendShipStatus { get; set; }

        public int UserOneId { get; set; }
        public MemberResponse UserOne { get; set; }

        public int UserTwoId { get; set; }
        public MemberResponse UserTwo { get; set; }

        public int ActionUserId { get; set; }
        public MemberResponse ActionUser { get; set; }
    }
}
