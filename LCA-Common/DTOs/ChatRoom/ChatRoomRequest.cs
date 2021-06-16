using LCA_Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.ChatRoom
{
    public class ChatRoomRequest : BaseDto
    {
        public int FriendshipId { get; set; }
    }
}
