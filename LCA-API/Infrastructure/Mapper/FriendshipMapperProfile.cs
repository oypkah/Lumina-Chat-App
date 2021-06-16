using AutoMapper;
using LCA_API.Infrastructure.Extensions;
using LCA_Common.DTOs.Friendship;
using LCA_Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCA_API.Infrastructure.Mapper
{
    public class FriendshipMapperProfile : Profile
    {
        public FriendshipMapperProfile()
        {
            CreateMap<Friendship, FriendshipRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Friendship, FriendshipResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
