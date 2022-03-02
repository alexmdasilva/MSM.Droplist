using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Maps
{
    public class ItemDropMap : EntityMapper<ItemDrop>
    {
        public override void Configure(EntityTypeBuilder<ItemDrop> builder)
        {
            builder.Property(itemDrop => itemDrop.Rate)
                .IsRequired();

            builder.Property(itemDrop => itemDrop.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
