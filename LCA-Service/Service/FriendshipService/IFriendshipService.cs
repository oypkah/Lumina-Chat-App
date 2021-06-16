using LCA_Core.Service;
using EF = LCA_Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LCA_Service.Service.FriendshipService
{
    public interface IFriendshipService : ICoreService<EF.Friendship>
    {
    }
}
