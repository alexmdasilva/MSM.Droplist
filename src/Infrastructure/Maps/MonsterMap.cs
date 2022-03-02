using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Maps
{
    public class MonsterMap : EntityMapper<Monster>
    {
        public override void Configure(EntityTypeBuilder<Monster> builder)
        {
            builder.Property(monster => monster.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(monster => monster.Index)
                .IsRequired();
        }
    }
}
