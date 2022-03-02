using Domain;
using Domain.Data;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MapListRepository : GenericRepository<Map>, IMapListRepository
    {
        private readonly ApplicationDbContext _context;

        public MapListRepository(ApplicationDbContext context) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Map>> GetAllMaps()
        {
            return await _context.Set<Map>()
                .OrderBy(map => map.Number)
                .ToListAsync();
        }

        public async Task Add(Map map)
        {
            await _context.Set<Map>()
               .AddAsync(map);
        }
    }
}
