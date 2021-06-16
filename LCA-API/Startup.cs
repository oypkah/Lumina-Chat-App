using AutoMapper;
using LCA_API.Hubs;
using LCA_API.Infrastructure.Models.Base;
using LCA_Common.Client.Services;
using LCA_Model.Context;
using LCA_Service.Service.ChatRoomService;
using LCA_Service.Service.FriendshipService;
using LCA_Service.Service.MemberService;
using LCA_Service.Service.MembersProfilePictureService;
using LCA_Service.Service.MessageService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA_API
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", reloadOnChange: true, optional: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", reloadOnChange: true, optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Cors
            services.AddCors(options =>
                    options.AddPolicy("CorsPolicy",
                        builder =>
                        {
                            builder.AllowAnyMethod().AllowAnyHeader().AllowCredentials().WithOrigins("http://localhost:3000/").SetIsOriginAllowed(origin => true);
                        }
                    )
                );

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddControllers();

            services.AddDbContext<DataContext>(option =>
            {
                option.UseSqlServer(Configuration["ConnectionStrings:Conn"])
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IWorkContext, ApiWorkContext>();

            services.AddTransient<IMemberService, MemberService>();
            services.AddTransient<IMessageService, MessageService>();
            services.AddTransient<IFriendshipService, FriendshipService>();
            services.AddTransient<IMembersProfilePictureService, MembersProfilePictureService>();
            services.AddTransient<IChatRoomService, ChatRoomService>();

            //Add AutoMapper
            services.AddAutoMapper(typeof(Startup));

            //Auth
            services
                .AddAuthentication(cfg =>
                {
                    cfg.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    cfg.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(option =>
                {
                    option.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = Configuration["Tokens:Issuer"],
                        ValidAudience = Configuration["Tokens:Audience"],
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Tokens:Key"]))
                    };
                });

            services.AddAuthorization();

            //services.AddAuthorization(auth =>
            //{
            //    auth.AddPolicy("RolePolicy", conf => { conf.RequireClaim(ClaimTypes.Role, "Admin"); });
            //});

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("CorsPolicy");

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chathub");
                endpoints.MapControllers();
            });
        }
    }
}
