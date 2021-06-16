using LCA_Common.Client.Enums;
using LCA_Common.DTOs.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.ChatRoom
{
    public class HomeChatRoomModel : BaseDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public MemberStatus MemberStatus { get; set; }

        public int UnreadMessageCount { get; set; }

        //Profile pic
        public string Filepath { get; set; }

        //Last Message
        public string Message { get; set; }

        //User id
        public int MemberId { get; set; }

    }
}
