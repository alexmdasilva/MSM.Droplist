namespace Application.Messages
{
    public abstract class MediatorResult
    {
        private readonly ICollection<string> _errors;

        public ICollection<string> Errors => _errors;
        public bool Succeeded => Errors.Any();

        public void AddError(string errorMessage)
        {
            _errors.Add(errorMessage);
        }
    }
}