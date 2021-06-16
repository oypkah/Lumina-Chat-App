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
                    Body = "Junior, nasılsın?",
                    MessageStatus = MessageStatus.Sent,
                    MessageImageStatus = MessageImageStatus.No,
                    SenderId = 3,
                    ReceivId = 1,
                    ChatRoomId = 1
                },
                new Message
                {
                    Id = 2,
                    Status = Status.Active,
                    CreatedDate = DateTime.Now,
                    CreatedComputerName = "Admin",
                    CreatedIp = "127.0.0.1",
                    ModifiedDate = DateTime.Now,
                    ModifiedComputerName = "Admin",
                    ModifiedIp = "127.0.0.1",
                    Body = "İyiyim, sen nasılsın?",
                    MessageStatus = MessageStatus.Sent,
                    MessageImageStatus = MessageImageStatus.No,
                    SenderId = 1,
                    ReceivId = 3,
                    ChatRoomId = 1
                });
        }
    }
}
