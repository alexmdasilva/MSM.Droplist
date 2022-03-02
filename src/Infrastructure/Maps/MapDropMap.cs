using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Maps
{
    public class MapDropMap : EntityMapper<MapDrop>
    {
        public override void Configure(EntityTypeBuilder<MapDrop> builder)
        {
            builder.HasMany(x => x.ItemDrops);

            builder.Property(map => map.MapId)
                .IsRequired();
        }
    }
}
