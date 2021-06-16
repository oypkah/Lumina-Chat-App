using LCA_Core.Service;
using EF = LCA_Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Service.Service.MemberService
{
    public interface IMemberService : ICoreService<EF.Member>
    {
    }
}
