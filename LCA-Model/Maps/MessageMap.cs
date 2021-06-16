using LCA_Core.Map;
using LCA_Model.Entities;
using LCA_Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Maps
{
    public class MessageMap : IEntityBuilder
    {
        public void Builder(ModelBuilder builder)
        {
            builder.Entity<Message>(entity =>
            {
                entity.ToTable("Messages");

                entity.HasExtended();

                entity.Property(x => x.Body).HasMaxLength(3000).IsRequired();

                entity
                    .HasOne(x => x.Sender)
                    .WithMany(x => x.SendingMessages)
                    .HasForeignKey(x => x.SenderId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .HasOne(x => x.Receiv)
                    .WithMany(x => x.ReceivingMessages)
                    .HasForeignKey(x => x.ReceivId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .HasOne(x => x.ChatRoom)
                    .WithMany(x => x.Messages)
                    .HasForeignKey(x => x.ChatRoomId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
