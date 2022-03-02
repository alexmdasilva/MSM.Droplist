using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Maps
{
    public class MapListMap : EntityMapper<Map>
    {
        public override void Configure(EntityTypeBuilder<Map> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Number)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
