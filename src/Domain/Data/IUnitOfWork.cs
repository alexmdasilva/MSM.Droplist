namespace Domain.Data
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();
    }
}