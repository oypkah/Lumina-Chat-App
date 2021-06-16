using AutoMapper;
using LCA_Service.Service.MemberService;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace LCA_API.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IMemberService _ms;
        private readonly IMapper _mapper;
        public ChatHub(
            IMemberService ms,
            IMapper mapper)
        {
            _ms = ms;
            _mapper = mapper;
        }

        public async override Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("GetMemberIdFromConnected");
        }

        public async Task SetMemberConnect(int id)
        {
            var currentMember = await _ms.GetById(id);
            currentMember.ConnectionId = Context.ConnectionId;
            await _ms.Update(currentMember);
        }

        //public override Task OnDisconnectedAsync(Exception exception)
        //{
        //}

        //public async Task SetMemberDisconnect(int id)
        //{
        //    var currentMember = await _ms.GetById(id);
        //    currentMember.ConnectionId = string.Empty;
        //    await _ms.Update(currentMember);
        //}
    }
}
