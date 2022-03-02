using MediatR;

namespace Application.Commands.AddMap
{
    public class AddMapCommandInput : IRequest<AddMapCommandResult>
    {
        public AddMapCommandInput(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public int Number { get; }
        public string Name { get; }
    }
}
