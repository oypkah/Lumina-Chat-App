using LCA_Model.Context;
using EF = LCA_Model.Entities;
using LCA_Service.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Service.Service.MemberService
{
    public class MemberService : BaseService<EF.Member>, IMemberService
    {
        public MemberService(DataContext context) : base(context)
        {
        }
    }
}
