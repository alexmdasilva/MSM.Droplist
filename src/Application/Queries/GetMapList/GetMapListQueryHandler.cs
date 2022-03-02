using Domain.Data;
using MediatR;

namespace Application.Queries.GetMapList
{
    public class GetMapListQueryHandler : IRequestHandler<GetMapListQueryInput, GetMapListQueryResult>
    {
        private readonly IMapListRepository _mapListRepository;

        public GetMapListQueryHandler(IMapListRepository mapListRepository)
        {
            _mapListRepository = mapListRepository ?? throw new ArgumentNullException(nameof(mapListRepository));
        }

        public async Task<GetMapListQueryResult> Handle(GetMapListQueryInput request, CancellationToken cancellationToken)
        {
            var maps = await _mapListRepository.GetAllMaps();

            return new GetMapListQueryResult
            {
                Maps = maps.Select(map => new MapListItemResult
                {
                    Name = map.Name,
                    Number = map.Number
                })
            };
        }
    }
}