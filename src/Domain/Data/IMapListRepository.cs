namespace Domain.Data
{
    public interface IMapListRepository : IRepository
    {
        public Task<IEnumerable<Map>> GetAllMaps();
        public Task Add(Map map);
    }
}
