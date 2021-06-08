using LCA_Core.Entity;
using LCA_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.SeedData
{
    public class MemberSeedData : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasData(
                new Member
                {
                    Id = 1,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    FirstName = "Furkan",
                    LastName = "Aslan",
                    UserName = "HostGhost",
                    Email = "furkan_aslan2209@hotmail.com",
                    Password = "1903",
                    About = "hope"
                },
                new Member
                {
                    Id = 2,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    FirstName = "Mehmetcan",
                    LastName = "Kural",
                    UserName = "DarkSouls",
                    Email = "mehmetcankural@hotmail.com",
                    Password = "1907",
                    About = "Turkiye"
                },
                new Member
                {
                    Id = 3,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    FirstName = "Kerem",
                    LastName = "Buğra",
                    UserName = "frkkrm16",
                    Email = "frkkrm16@hotmail.com",
                    Password = "1907",
                    About = "But I can't walk on the path of the right, because I'm wrong.."
                });
        }
    }
}
