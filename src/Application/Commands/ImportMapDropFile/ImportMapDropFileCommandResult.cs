namespace Application.Commands.ImportMapDropFile
{
    public class ImportMapDropFileCommandResult
    {
        public ImportMapDropFileCommandResult()
        {

        }
        public ImportMapDropFileCommandResult(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}