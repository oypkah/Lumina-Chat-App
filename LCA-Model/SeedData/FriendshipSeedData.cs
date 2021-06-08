using LCA_Core.Entity;
using LCA_Model.Entities;
using LCA_Model.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.SeedData
{
    public class FriendshipSeedData : IEntityTypeConfiguration<Friendship>
    {
        public void Configure(EntityTypeBuilder<Friendship> builder)
        {
            builder.HasData(
                new Friendship
                {
                    Id = 1,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    FriendShipStatus = FriendShipStatus.Accepted,
                    UserOneId = 1,
                    UserTwoId = 2,
                    ActionUserId = 2
                },
                new Friendship
                {
                    Id = 2,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    FriendShipStatus = FriendShipStatus.Accepted,
                    UserOneId = 1,
                    UserTwoId = 3,
                    ActionUserId = 3
                });
        }
    }
}
