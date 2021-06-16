using AutoMapper;
using LCA_Common.Client.Models;
using LCA_Common.DTOs.Friendship;
using LCA_Model.Entities.Enums;
using LCA_Service.Service.FriendshipService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCA_API.Controllers
{
    [Authorize]
    [Route("api/friendship")]
    public class FriendshipController : BaseApiController<FriendshipController>
    {
        private readonly IFriendshipService _fs;
        private readonly IMapper _mapper;
        public FriendshipController(
            IFriendshipService fs,
            IMapper mapper)
        {
            _fs = fs;
            _mapper = mapper;
        }
    }
}
