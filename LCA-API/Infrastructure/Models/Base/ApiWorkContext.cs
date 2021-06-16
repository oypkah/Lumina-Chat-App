using AutoMapper;
using LCA_Common.Client.Services;
using LCA_Common.DTOs.Member;
using LCA_Service.Service.MemberService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace LCA_API.Infrastructure.Models.Base
{
    public class ApiWorkContext : IWorkContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMemberService _ms;
        private readonly IMapper _mapper;
        public ApiWorkContext(
            IHttpContextAccessor httpContextAccessor,
            IMemberService ms,
            IMapper mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _ms = ms;
            _mapper = mapper;
        }

        public MemberResponse CurrentUser {
            get {
                var authResult = _httpContextAccessor.HttpContext.AuthenticateAsync(JwtBearerDefaults.AuthenticationScheme).Result;
                if (!authResult.Succeeded)
                    return null;

                var email = authResult.Principal.Claims.FirstOrDefault(x => x.Type == System.Security.Claims.ClaimTypes.Email).Value;
                var userId = authResult.Principal.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value;

                MemberResponse rm = _mapper.Map<MemberResponse>(_ms.GetById(int.Parse(userId)).Result);

                return rm;
            }
            set {
                CurrentUser = value;
            }
        }
    }
}
