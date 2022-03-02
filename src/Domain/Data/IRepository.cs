namespace Domain.Data
{
    public interface IRepository
    {
        public IUnitOfWork UnitOfWork { get; }
    }
}