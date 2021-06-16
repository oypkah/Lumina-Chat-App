using LCA_Model.Context;
using EF = LCA_Model.Entities;
using LCA_Service.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LCA_Model.Entities;
using System.Linq;
using LCA_Model.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace LCA_Service.Service.FriendshipService
{
    public class FriendshipService : BaseService<EF.Friendship>, IFriendshipService
    {
        public FriendshipService(DataContext context) : base(context)
        {
        }
    }
}
