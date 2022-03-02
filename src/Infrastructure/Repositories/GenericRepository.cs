using Domain;
using Domain.Data;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public abstract class GenericRepository<TEntity> : IRepository where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        protected GenericRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IUnitOfWork UnitOfWork => _context;
    }
}
