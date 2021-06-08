using LCA_Core.Map;
using LCA_Model.Entities;
using LCA_Model.Maps.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Maps
{
    public class MembersProfilePictureMap : IEntityBuilder
    {
        public void Builder(ModelBuilder builder)
        {
            builder.Entity<MembersProfilePicture>(entity =>
            {
                entity.ToTable("MembersProfilePictures");

                entity.HasExtended();

                entity.Property(x => x.Filename).HasMaxLength(255).IsRequired(false);
                entity.Property(x => x.Filepath).HasMaxLength(255).IsRequired(false);
            });
        }
    }
}
