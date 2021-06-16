using AutoMapper;
using LCA_Common.Client.Models;
using LCA_Common.DTOs.ChatRoom;
using LCA_Common.DTOs.Message;
using LCA_Service.Service.ChatRoomService;
using LCA_Service.Service.MessageService;
using Microsoft.AspNetCore.Authorization;
using CommonEnums = LCA_Common.Client.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS = LCA_Core.Entity;
using LCA_Model.Entities;
using ModelEnums = LCA_Model.Entities.Enums;
using Microsoft.AspNetCore.SignalR;
using LCA_API.Hubs;

namespace LCA_API.Controllers
{
    [Authorize]
    [Route("api/chatroom")]
    public class ChatRoomController : BaseApiController<ChatRoomController>
    {
        private readonly IChatRoomService _crs;
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;
        private readonly IHubContext<ChatHub> _hubContext;
        public ChatRoomController(
            IChatRoomService crs,
            IMessageService messageService,
            IMapper mapper,
            IHubContext<ChatHub> hubContext)
        {
            _crs = crs;
            _messageService = messageService;
            _mapper = mapper;
            _hubContext = hubContext;
        }

        [HttpGet("{id}")]
        public async Task<WebApiResponse<List<HomeChatRoomModel>>> GetChatRoomsForHome(int id)
        {
            try
            {
                var homeChatRoomModels = new List<HomeChatRoomModel>();
                var result = _mapper.Map<List<ChatRoomResponse>>(await _crs.GetDefault(x => x.Status == CS.Status.Active && x.Friendship.UserOneId == id || x.Friendship.UserTwoId == id, x => x.Friendship.UserOne.MembersProfilePicture, x => x.Friendship.UserOne.SendingMessages, x => x.Friendship.UserTwo.MembersProfilePicture, x => x.Friendship.UserTwo.SendingMessages).ToListAsync());
                foreach (var item in result)
                {
                    if (item.Friendship.UserOneId != id)
                    {
                        var member = item.Friendship.UserOne;
                        var hcrm = new HomeChatRoomModel()
                        {
                            Id = item.Id,
                            CreatedComputerName = item.CreatedComputerName,
                            CreatedDate = item.CreatedDate,
                            CreatedIP = item.CreatedIP,
                            Status = member.Status,
                            FirstName = member.FirstName,
                            LastName = member.LastName,
                            UserName = member.UserName,
                            MemberStatus = member.MemberStatus,
                            Message = item.LastMessage,
                            Filepath = member.MembersProfilePicture.Filepath,
                            MemberId = member.Id,
                            UnreadMessageCount = member.SendingMessages.Where(x => x.MessageStatus == CommonEnums.MessageStatus.Sent).Count()
                        };
                        homeChatRoomModels.Add(hcrm);
                    }

                    if (item.Friendship.UserTwoId != id)
                    {
                        var member = item.Friendship.UserTwo;
                        var hcrm = new HomeChatRoomModel()
                        {
                            Id = item.Id,
                            CreatedComputerName = item.CreatedComputerName,
                            CreatedDate = item.CreatedDate,
                            CreatedIP = item.CreatedIP,
                            Status = member.Status,
                            FirstName = member.FirstName,
                            LastName = member.LastName,
                            UserName = member.UserName,
                            MemberStatus = member.MemberStatus,
                            Message = item.LastMessage,
                            Filepath = member.MembersProfilePicture.Filepath,
                            MemberId = member.Id,
                            UnreadMessageCount = member.SendingMessages.Where(x => x.MessageStatus == CommonEnums.MessageStatus.Sent).Count()
                        };
                        homeChatRoomModels.Add(hcrm);
                    }
                }
                return new WebApiResponse<List<HomeChatRoomModel>>("Success", true, homeChatRoomModels);
            }
            catch (Exception ex)
            {
                return new WebApiResponse<List<HomeChatRoomModel>>(ex.Message, false);
            }
        }


        [HttpGet("getmessages/{id}/{requestMemberId}")]
        public async Task<WebApiResponse<List<MessageResponse>>> GetMessages(int id, int requestMemberId)
        {
            try
            {
                var result = _mapper.Map<List<MessageResponse>>(await _messageService.GetDefault(x => x.Status == CS.Status.Active && x.ChatRoomId == id).ToListAsync());
                if (result != null)
                {
                    if (result.Any(x => x.MessageStatus == CommonEnums.MessageStatus.Sent))
                    {
                        await MakeMessagesSeen(result, requestMemberId);
                        return new WebApiResponse<List<MessageResponse>>("Success", true, result);
                    }
                    else
                        return new WebApiResponse<List<MessageResponse>>("Success", true, result);
                }
                else
                    return new WebApiResponse<List<MessageResponse>>("Error", false);
            }
            catch (Exception ex)
            {
                return new WebApiResponse<List<MessageResponse>>(ex.Message, false);
            }
        }

        public async Task<bool> MakeMessagesSeen(List<MessageResponse> result, int requestMemberId)
        {
            var unreadMessages = _mapper.Map<List<Message>>(result.Where(x => x.MessageStatus == CommonEnums.MessageStatus.Sent).ToList());
            unreadMessages.ForEach(item => {
                if (item.SenderId != requestMemberId)
                    item.MessageStatus = ModelEnums.MessageStatus.Seen;
            });
            return await _messageService.UpdateRange(unreadMessages);
        }
    }
}
