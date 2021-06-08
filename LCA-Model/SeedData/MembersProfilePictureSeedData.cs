using LCA_Core.Entity;
using LCA_Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.SeedData
{
    public class MembersProfilePictureSeedData : IEntityTypeConfiguration<MembersProfilePicture>
    {
        public void Configure(EntityTypeBuilder<MembersProfilePicture> builder)
        {
            builder.HasData(
                new MembersProfilePicture
                {
                    Id = 1,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    Filename = ".jpg",
                    Filepath = "\\src\\Images\\furkanaslan.jpg"
                },
                new MembersProfilePicture
                {
                    Id = 2,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    Filename = ".jpg",
                    Filepath = "\\src\\Images\\mehmetkural.jpg"
                },
                new MembersProfilePicture
                {
                    Id = 3,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    Filename = ".jpg",
                    Filepath = "\\src\\Images\\kerembugra.jpg"
                });
        }
    }
}
