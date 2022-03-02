namespace Domain
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public BaseEntity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}
