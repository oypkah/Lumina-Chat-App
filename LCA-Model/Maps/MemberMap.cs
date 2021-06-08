using LCA_Core.Map;
using LCA_Model.Entities;
using LCA_Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Maps
{
    public class MemberMap : IEntityBuilder
    {
        public void Builder(ModelBuilder builder)
        {
            builder.Entity<Member>(entity =>
            {
                entity.ToTable("Members");

                entity.HasExtended();

                entity.Property(x => x.FirstName).HasMaxLength(255).IsRequired();
                entity.Property(x => x.LastName).HasMaxLength(255).IsRequired();
                entity.Property(x => x.UserName).HasMaxLength(255).IsRequired();
                entity.Property(x => x.Email).HasMaxLength(255).IsRequired();
                entity.Property(x => x.Password).HasMaxLength(255).IsRequired();
                entity.Property(x => x.About).HasMaxLength(255).IsRequired(false);

                entity
                    .HasOne(x => x.MembersProfilePicture)
                    .WithOne(x => x.Member)
                    .HasForeignKey<MembersProfilePicture>(x=>x.MemberId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
