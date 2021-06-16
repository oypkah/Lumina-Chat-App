using LCA_Core.Map;
using LCA_Model.Entities;
using LCA_Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Maps
{
    public class ChatRoomMap : IEntityBuilder
    {
        public void Builder(ModelBuilder builder)
        {
            builder.Entity<ChatRoom>(entity =>
            {
                entity.ToTable("ChatRooms");

                entity.HasExtended();

                entity.Property(x => x.FriendshipId).IsRequired();
                entity.Property(x => x.LastMessage).HasMaxLength(30).IsRequired(false);
            });
        }
    }
}
