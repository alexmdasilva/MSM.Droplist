namespace Application.Commands.AddMap
{
    public class AddMapCommandResult
    {
        public AddMapCommandResult(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}