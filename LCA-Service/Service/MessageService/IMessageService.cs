using LCA_Core.Service;
using EF = LCA_Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Service.Service.MessageService
{
    public interface IMessageService : ICoreService<EF.Message>
    {
    }
}
