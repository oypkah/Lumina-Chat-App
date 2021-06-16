using AutoMapper;
using LCA_API.Hubs;
using LCA_Common.Client.Models;
using LCA_Common.DTOs.Member;
using LCA_Common.DTOs.Message;
using LCA_Model.Entities;
using LCA_Service.Service.MemberService;
using Microsoft.AspNetCore.Authorization;
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
    [Route("api/member")]
    public class MemberController : BaseApiController<MemberController>
    {
        private readonly IMemberService _ms;
        private readonly IHubContext<ChatHub> _hubContext;
        private readonly IMapper _mapper;
        public MemberController(
            IMemberService ms,
            IHubContext<ChatHub> hubContext,
            IMapper mapper
            )
        {
            _ms = ms;
            _hubContext = hubContext;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<WebApiResponse<HeaderMemberModel>> GetMember(int id)
        {
            try
            {
                var currentMember = _mapper.Map<HeaderMemberModel>(await _ms.GetById(id, x => x.MembersProfilePicture));
                if (currentMember != null)
                    return new WebApiResponse<HeaderMemberModel>("Success", true, currentMember);
                else
                    return new WebApiResponse<HeaderMemberModel>("Error", false);
            }
            catch (Exception ex)
            {
                return new WebApiResponse<HeaderMemberModel>(ex.Message, false);
            }
        }

        [HttpGet("getbyusername/{username}")]
        public async Task<WebApiResponse<HeaderMemberModel>> GetMember(string username)
        {
            try
            {
                var currentMember = _mapper.Map<HeaderMemberModel>(await _ms.GetByDefault(x => x.UserName == username, x => x.MembersProfilePicture));
                if (currentMember != null)
                    return new WebApiResponse<HeaderMemberModel>("Success", true, currentMember);
                else
                    return new WebApiResponse<HeaderMemberModel>("Error", false);
            }
            catch (Exception ex)
            {
                return new WebApiResponse<HeaderMemberModel>(ex.Message, false);
            }
        }

        [HttpPost("setmembertypingstatus")]
        public async Task<WebApiResponse<int>> SetMemberTypingStatus(MemberTypingModel request)
        {
            try
            {
                if (request.IsTyping)
                {
                    var member = await _ms.GetById(request.Id);
                    var receivMemberConnId = await _ms.GetDefault(x => x.Id == request.ReceivMemberId).Select(x => x.ConnectionId).FirstOrDefaultAsync();
                    member.IsMemberTypingStatus = LCA_Model.Entities.Enums.IsMemberTypingStatus.Yes;
                    await _ms.Update(member);
                    await _hubContext.Clients.Client(receivMemberConnId).SendAsync("getIsMemberTyping", member.IsMemberTypingStatus, member.MemberStatus);
                }
                else
                {
                    var member = await _ms.GetById(request.Id);
                    var receivMemberConnId = await _ms.GetDefault(x => x.Id == request.ReceivMemberId).Select(x => x.ConnectionId).FirstOrDefaultAsync();
                    member.IsMemberTypingStatus = LCA_Model.Entities.Enums.IsMemberTypingStatus.No;
                    await _ms.Update(member);
                    await _hubContext.Clients.Client(receivMemberConnId).SendAsync("getIsMemberTyping", member.IsMemberTypingStatus, member.MemberStatus);
                }

                return new WebApiResponse<int>("Ok", true, 200);
            }
            catch (Exception ex)
            {
                return new WebApiResponse<int>(ex.Message, false, 500);
            }
        }
    }
}
