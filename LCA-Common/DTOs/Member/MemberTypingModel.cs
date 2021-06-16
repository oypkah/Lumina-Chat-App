using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.Member
{
    public class MemberTypingModel
    {
        public int Id { get; set; }
        public bool IsTyping { get; set; }
        public int ReceivMemberId { get; set; }
    }
}
