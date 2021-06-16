using LCA_Common.Client.Enums;
using LCA_Common.DTOs.Base;
using LCA_Common.DTOs.ChatRoom;
using LCA_Common.DTOs.Member;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.Message
{
    public class MessageResponse : BaseDto
    {
        public string Body { get; set; }
        public MessageStatus MessageStatus { get; set; }
        public MessageImageStatus MessageImageStatus { get; set; }

        public int SenderId { get; set; }
        public MemberResponse Sender { get; set; }

        public int ReceivId { get; set; }
        public MemberResponse Receiv { get; set; }

        public int ChatRoomId { get; set; }
        public ChatRoomResponse ChatRoom { get; set; }
    }
}
