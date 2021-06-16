using LCA_Model.Context;
using EF = LCA_Model.Entities;
using LCA_Service.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Service.Service.MessageService
{
    public class MessageService : BaseService<EF.Message>, IMessageService
    {
        public MessageService(DataContext context) : base(context)
        {
        }
    }
}
