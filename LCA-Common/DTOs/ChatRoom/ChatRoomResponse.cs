using LCA_Common.DTOs.Base;
using LCA_Common.DTOs.Friendship;
using LCA_Common.DTOs.Message;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.ChatRoom
{
    public class ChatRoomResponse : BaseDto
    {
        public int FriendshipId { get; set; }
        public FriendshipResponse Friendship { get; set; }
        public string LastMessage { get; set; }
        public ICollection<MessageResponse> Messages { get; set; }
    }
}
