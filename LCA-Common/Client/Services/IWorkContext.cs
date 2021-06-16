using LCA_Common.DTOs.Member;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.Client.Services
{
    public interface IWorkContext
    {
        MemberResponse CurrentUser { get; set; }
    }
}
