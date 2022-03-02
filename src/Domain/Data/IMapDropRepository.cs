using Domain.Entities;

namespace Domain.Data
{
    public interface IMapDropRepository : IRepository
    {
        public Task Add(MapDrop mapDrop);
        public IQueryable<MapDrop> GetAsNoTracking();
    }
}
