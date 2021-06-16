using AutoMapper;
using LCA_API.Hubs;
using LCA_Common.Client.Models;
using LCA_Common.DTOs.Message;
using LCA_Model.Entities;
using LCA_Service.Service.ChatRoomService;
using LCA_Service.Service.MemberService;
using LCA_Service.Service.MessageService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCA_API.Controllers
{
    [Authorize]
    [Route("api/message")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _mess;
        private readonly IChatRoomService _crs;
        private readonly IMemberService _ms;
        private readonly IHubContext<ChatHub> _hubContext;
        private readonly IMapper _mapper;
        public MessageController(
            IMessageService mess,
            IChatRoomService crs,
            IMemberService ms,
            IHubContext<ChatHub> hubContext,
            IMapper mapper)
        {
            _mess = mess;
            _crs = crs;
            _ms = ms;
            _hubContext = hubContext;
            _mapper = mapper;
        }

        [HttpGet("getrecentlymessages/{id}")]
        public async Task<WebApiResponse<List<MessageResponse>>> GetRecentlyMessages(int id)
        {
            var messageResponses = _mapper.Map<List<MessageResponse>>(await _mess.GetDefault(x => x.SenderId == id || x.ReceivId == id,x=>x.Receiv,x=>x.Sender).OrderByDescending(x=>x.CreatedDate).Take(1).ToListAsync());
            return new WebApiResponse<List<MessageResponse>>("Success", true, messageResponses);
        }

        [HttpPost("addmessage")]
        public async Task<WebApiResponse<MessageResponse>> AddMessage([FromBody] MessageRequest request)
        {
            try
            {
                var message = await _mess.Add(_mapper.Map<Message>(request));
                var chatRoom = await _crs.GetById(message.ChatRoomId);
                var recievMemberConnId = await _ms.GetDefault(x => x.Id == request.ReceivId).Select(x => x.ConnectionId).FirstOrDefaultAsync();
                chatRoom.LastMessage = message.Body.Length >= 27 ? message.Body.Substring(0, 27) + "..." : chatRoom.LastMessage = message.Body;
                await _crs.Update(chatRoom);
                var messageResponse = _mapper.Map<MessageResponse>(message);
                await _hubContext.Clients.Client(recievMemberConnId).SendAsync("getMessage", messageResponse);
                return new WebApiResponse<MessageResponse>("Success", true, messageResponse);
            }
            catch (Exception ex)
            {
                return new WebApiResponse<MessageResponse>(ex.Message, false);
            }
        }
    }
}
