using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Maps
{
    public abstract class EntityMapper<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);
    }
}
