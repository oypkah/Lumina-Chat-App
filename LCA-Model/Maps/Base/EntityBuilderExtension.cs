using LCA_Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Model.Maps.Base
{
    public static class EntityBuilderExtension
    {
        public static void HasExtended<T>(this EntityTypeBuilder<T> entity) where T : CoreEntity
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Id).IsRequired();
            entity.Property(x => x.Status).IsRequired();

            entity.Property(x => x.CreatedDate).IsRequired(false);
            entity.Property(x => x.CreatedComputerName).HasMaxLength(250).IsRequired(false);
            entity.Property(x => x.CreatedIp).HasMaxLength(64).IsRequired(false);

            entity.Property(x => x.ModifiedDate).IsRequired(false);
            entity.Property(x => x.ModifiedComputerName).HasMaxLength(250).IsRequired(false);
            entity.Property(x => x.ModifiedIp).HasMaxLength(64).IsRequired(false);
        }
    }
}
