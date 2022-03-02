using Domain.Entities;

namespace Domain.Data
{
    public interface IMonsterRepository : IRepository
    {
        public Task Add(Monster monster);
    }
}
