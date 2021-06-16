using AutoMapper;
using LCA_API.Infrastructure.Extensions;
using LCA_Common.DTOs.Message;
using LCA_Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCA_API.Infrastructure.Mapper
{
    public class MessageMapperProfile : Profile
    {
        public MessageMapperProfile()
        {
            CreateMap<Message, MessageRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Message, MessageResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
