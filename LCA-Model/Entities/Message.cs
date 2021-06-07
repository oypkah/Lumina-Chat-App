using LCA_Core.Entity;
using LCA_Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Entities
{
    public class Message : CoreEntity
    {
        public string Body { get; set; }
        public MessageStatus MessageStatus { get; set; }
        public MessageImageStatus MessageImageStatus { get; set; }

        public int SenderId { get; set; }
        public Member Sender { get; set; }

        public int ReceivId { get; set; }
        public Member Receiv { get; set; }
    }
}
