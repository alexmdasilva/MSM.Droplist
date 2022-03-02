using Domain.Data;
using Domain.Entities;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class MapDropRepository : GenericRepository<MapDrop>, IMapDropRepository
    {
        private readonly ApplicationDbContext _context;
        public MapDropRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task Add(MapDrop mapDrop)
        {
            await _context.Set<MapDrop>().AddAsync(mapDrop);
        }

        public IQueryable<MapDrop> GetAsNoTracking()
        {
            return _context.Set<MapDrop>().AsQueryable();
        }
    }
}
