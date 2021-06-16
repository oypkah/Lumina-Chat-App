using AutoMapper;
using LCA_API.Infrastructure.Extensions;
using LCA_Common.DTOs.Member;
using LCA_Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCA_API.Infrastructure.Mapper
{
    public class MemberMapperProfile : Profile
    {
        public MemberMapperProfile()
        {
            CreateMap<Member, MemberRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Member, MemberResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<Member, HeaderMemberModel>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
            
        }
    }
}
