using AutoMapper;
using LCA_API.Infrastructure.Helper;
using LCA_Common.Client.Extensions;
using LCA_Common.Client.Models;
using LCA_Common.DTOs.Account;
using LCA_Common.DTOs.Member;
using LCA_Model.Entities;
using LCA_Service.Service.MemberService;
using LCA_Service.Service.MembersProfilePictureService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using LCA_Model.Entities.Enums;
using Microsoft.AspNetCore.SignalR;
using LCA_API.Hubs;

namespace LCA_API.Controllers
{
    [Route("api/account")]
    public class AccountController : BaseApiController<AccountController>
    {
        private readonly IWebHostEnvironment _env;
        private readonly IMemberService _ms;
        private readonly IMembersProfilePictureService _pps;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IHubContext<ChatHub> _hubContext;
        public AccountController(
            IWebHostEnvironment env,
            IMemberService ms,
            IMembersProfilePictureService pps,
            IMapper mapper,
            IConfiguration configuration,
            IHubContext<ChatHub> hubContext)
        {
            _env = env;
            _ms = ms;
            _pps = pps;
            _mapper = mapper;
            _configuration = configuration;
            _hubContext = hubContext;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<WebApiResponse<MemberResponse>> Login(LoginRequest request)
        {
            var result = await _ms.GetByDefault(x => x.Email == request.Email && x.Password == request.Password);
            if (result != null)
            {
                MemberResponse rm = _mapper.Map<MemberResponse>(result);
                rm = await MakeMemberOnline(rm);
                if (rm != null)
                {
                    rm.AccessToken = SetAccessToken(rm);
                    rm.Password = string.Empty;
                    rm.Role = null;
                    await _hubContext.Clients.All.SendAsync("getMemberStatus", rm.MemberStatus, rm.Id);
                    return new WebApiResponse<MemberResponse>("Success", true, rm);
                }
                else
                    return new WebApiResponse<MemberResponse>("Server Error", false);
            }
            return new WebApiResponse<MemberResponse>("User Not Found", false);
        }

        [HttpPost]
        public async Task<MemberResponse> MakeMemberOnline(MemberResponse response)
        {
            var member = _mapper.Map<Member>(response);
            member.MemberStatus = MemberStatus.Online;
            member.LastLoginDate = DateTime.Now;

            var result = _mapper.Map<MemberResponse>(await _ms.Update(member));

            if (result != null)
                return result;
            else
                return result;
        }

        [HttpGet("logout/{id}")]
        public async Task<WebApiResponse<int>> Logout(int id)
        {
            var currentMember = _mapper.Map<Member>(await _ms.GetById(id));
            currentMember.MemberStatus = MemberStatus.Offline;
            currentMember.LastLogoutDate = DateTime.Now;
            currentMember.ConnectionId = string.Empty;
            currentMember.IsMemberTypingStatus = IsMemberTypingStatus.No;

            currentMember = await _ms.Update(currentMember);

            if (currentMember != null)
            {
                await _hubContext.Clients.All.SendAsync("getMemberStatus", currentMember.MemberStatus, currentMember.Id);
                return new WebApiResponse<int>("Ok", true, 200);
            }
            else
                return new WebApiResponse<int>("Error", false, 500);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<WebApiResponse<MemberResponse>> Register([FromForm]RegisterRequest request)
        {
            var emailResult = await _ms.Any(x => x.Email == request.Email);

            if (emailResult)
                return new WebApiResponse<MemberResponse>("Email Already Exist", false);
            else
            {
                var userNameResult = await _ms.Any(x => x.UserName == request.UserName);
                if (userNameResult)
                    return new WebApiResponse<MemberResponse>("User Name Not Available", false);
                else
                {
                    //var uploadResult = Upload.imageUpload(_env, file, out bool sonuc);

                    bool sonuc = true;

                    if (sonuc)
                    {
                        var result = _mapper.Map<Member>(request);
                        return new WebApiResponse<MemberResponse>("User Name Not Available", false);
                    }
                    return new WebApiResponse<MemberResponse>("User Name Not Available", false);
                }
            }
        }

        [HttpGet("refreshtoken")]
        public async Task<WebApiResponse<GetAccessToken>> RefreshToken([FromQuery] RefreshToken request)
        {
            if (string.IsNullOrEmpty(request.Refresh_Token))
                throw new Exception("Invalid Refresh Token");

            var key = request.Refresh_Token.Decrypt();
            var userInfo = key.Split('_');
            if (userInfo.Length < 3 || userInfo[0] != request.User_Name)
                throw new Exception("Invalid Token Renewal");

            var result = await _ms.GetByDefault(x => x.Email == userInfo[0] && x.Password == userInfo[1]);
            if (result != null)
            {
                MemberResponse rm = _mapper.Map<MemberResponse>(result);
                rm.AccessToken = SetAccessToken(rm);
                rm.Password = string.Empty;
                return new WebApiResponse<GetAccessToken>("Success", true, rm.AccessToken);
            }
            return new WebApiResponse<GetAccessToken>("User Not Found", false);
        }

        private GetAccessToken SetAccessToken(MemberResponse rm)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Email, rm.Email),
                new Claim(JwtRegisteredClaimNames.Jti, rm.Id.ToString()),
                new Claim(ClaimTypes.Role, rm.Role)
            };

            //JWT
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["Tokens:Expires"]));
            var ticks = expires.ToUnixTime();

            var jwtSecurityToken = new JwtSecurityToken(
                    issuer: _configuration["Tokens:Issuer"],
                    audience: _configuration["Tokens:Audience"],
                    claims: claims,
                    expires: expires,
                    signingCredentials: signingCredentials
                );

            return new GetAccessToken
            {
                TokenType = "LuminaAccessToken",
                AccessToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Expires = ticks,
                RefreshToken = $"{rm.Email}_{rm.Password}_{ticks}".Encrypt()
            };

            //var tokenDescriptor = new SecurityTokenDescriptor()
            //{
            //    Subject = new ClaimsIdentity(claims),
            //    Issuer = _configuration["Tokens:Issuer"],
            //    Audience = _configuration["Tokens:Audience"],
            //    Expires = expires,
            //    SigningCredentials = signingCredentials
            //};

            //var tokenHandler = new JwtSecurityTokenHandler();
            //var token = tokenHandler.CreateToken(tokenDescriptor);

            //return new GetAccessToken
            //{
            //    TokenType = "LuminaAccessToken",
            //    AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
            //    Expires = ticks,
            //    RefreshToken = $"{rm.Email}_{rm.Password}_{ticks}".Encrypt()
            //};
        }
    }
}
