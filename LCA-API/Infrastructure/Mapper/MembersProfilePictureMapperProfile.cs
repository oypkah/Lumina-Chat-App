using AutoMapper;
using LCA_API.Infrastructure.Extensions;
using LCA_Common.DTOs.MembersProfilePicture;
using LCA_Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCA_API.Infrastructure.Mapper
{
    public class MembersProfilePictureMapperProfile : Profile
    {
        public MembersProfilePictureMapperProfile()
        {
            CreateMap<MembersProfilePicture, MembersProfilePictureRequest>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<MembersProfilePicture, MembersProfilePictureResponse>()
                .ReverseMap()
                .IgnoreAllNonExisting()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
