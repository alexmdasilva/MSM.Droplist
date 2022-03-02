using Domain;
using Domain.Data;
using MediatR;

namespace Application.Commands.AddMap
{
    public class AddMapCommandHandler : IRequestHandler<AddMapCommandInput, AddMapCommandResult>
    {
        private readonly IMapListRepository _mapListRepository;

        public AddMapCommandHandler(IMapListRepository mapListRepository)
        {
            _mapListRepository = mapListRepository ?? throw new ArgumentNullException(nameof(mapListRepository));
        }

        public async Task<AddMapCommandResult> Handle(AddMapCommandInput input, CancellationToken cancellationToken)
        {
            var map = new Map(input.Number, input.Name);

            await _mapListRepository.Add(map);

            await _mapListRepository.UnitOfWork.CommitAsync();

            return new AddMapCommandResult(map.Id);
        }
    }
}
