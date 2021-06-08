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
    public class MessageSeedData : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasData(
                new Message
                {
                    Id = 1,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    Body = "Test",
                    MessageStatus = MessageStatus.Sent,
                    MessageImageStatus = MessageImageStatus.No,
                    SenderId = 1,
                    ReceivId = 3
                });
        }
    }
}
