using Domain;
using Domain.Data;
using Domain.Entities;
using Infrastructure.Maps;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Map> Map { get; set; }
        public DbSet<MapDrop> MapDrop { get; set; }
        public DbSet<ItemDrop> ItemDrop { get; set; }
        public DbSet<Monster> Monster { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapListMap());
            modelBuilder.ApplyConfiguration(new MapDropMap());
            modelBuilder.ApplyConfiguration(new MonsterMap());
            modelBuilder.ApplyConfiguration(new MapListMap());
        }

        public async Task<bool> CommitAsync()
        {
            return await SaveChangesAsync() > 0;
        }

    }
}
