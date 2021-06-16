using AutoMapper;
using LCA_API.Infrastructure.Extensions;
using LCA_Common.DTOs.ChatRoom;
using LCA_Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCA_API.Infrastructure.Mapper
{
    public class ChatRoomMapperProfile : Profile
    {
        public ChatRoomMapperProfile()
        {
            CreateMap<ChatRoom, ChatRoomRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<ChatRoom, ChatRoomResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
