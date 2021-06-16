using LCA_Core.Map;
using LCA_Model.Entities;
using LCA_Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Maps
{
    public class FriendshipMap : IEntityBuilder
    {
        public void Builder(ModelBuilder builder)
        {
            builder.Entity<Friendship>(entity =>
            {
                entity.ToTable("Friendships");

                entity.HasExtended();

                entity.Property(x => x.UserOneId).IsRequired();
                entity.Property(x => x.UserTwoId).IsRequired();
                entity.Property(x => x.ActionUserId).IsRequired();

                entity
                    .HasOne(x => x.UserOne)
                    .WithMany(x => x.FirstFriendships)
                    .HasForeignKey(x => x.UserOneId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .HasOne(x => x.UserTwo)
                    .WithMany(x => x.SecondFriendships)
                    .HasForeignKey(x => x.UserTwoId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .HasOne(x => x.ActionUser)
                    .WithMany(x => x.ActionFriendships)
                    .HasForeignKey(x => x.ActionUserId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity
                    .HasOne(x => x.ChatRoom)
                    .WithOne(x => x.Friendship)
                    .HasForeignKey<ChatRoom>(x => x.FriendshipId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
