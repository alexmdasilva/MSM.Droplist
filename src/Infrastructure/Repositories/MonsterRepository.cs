using Domain.Data;
using Domain.Entities;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MonsterRepository : GenericRepository<Monster>, IMonsterRepository
    {
        private readonly ApplicationDbContext _context;

        public MonsterRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task Add(Monster monster)
        {
            await _context.Set<Monster>()
                .AddAsync(monster);
        }
    }
}
