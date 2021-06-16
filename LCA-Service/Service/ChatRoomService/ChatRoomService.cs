using LCA_Service.Service.Base;
using EF = LCA_Model.Entities;
using LCA_Model.Context;

namespace LCA_Service.Service.ChatRoomService
{
    public class ChatRoomService : BaseService<EF.ChatRoom>, IChatRoomService
    {
        public ChatRoomService(DataContext context) : base(context)
        {
        }
    }
}
