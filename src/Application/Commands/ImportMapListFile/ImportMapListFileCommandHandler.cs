using Application.Services;
using Domain;
using Domain.Data;
using MediatR;

namespace Application.Commands.ImportMapListFile
{
    public class ImportMapListFileCommandHandler : IRequestHandler<ImportMapListFileCommandInput, ImportMapListFileCommandResult>
    {
        private readonly IXmlDeserializer _deserializer;
        private readonly IMapListRepository _mapListRepository;

        public ImportMapListFileCommandHandler(IXmlDeserializer deserializer, IMapListRepository mapListRepository)
        {
            _deserializer = deserializer ?? throw new ArgumentNullException(nameof(deserializer));
            _mapListRepository = mapListRepository ?? throw new ArgumentNullException(nameof(mapListRepository));
        }

        public async Task<ImportMapListFileCommandResult> Handle(ImportMapListFileCommandInput request, CancellationToken cancellationToken)
        {
            var stream = new MemoryStream();

            await request.File.CopyToAsync(stream, cancellationToken);

            var deserializedMapList = _deserializer.DeserializeXml<MapList>(stream);

            var maps = deserializedMapList?
                .DefaultMaps
                .Maps
                .Select(map => new Map(map.Number, ExtractMapNameFromFile(map.Name)));

            if (maps is null)
                return new ImportMapListFileCommandResult();

            foreach (var map in maps)
            {
                await _mapListRepository.Add(map);
            }

            await _mapListRepository.UnitOfWork.CommitAsync();

            return new ImportMapListFileCommandResult
            {
                MapQuantity = maps.Count()
            };
        }

        private string ExtractMapNameFromFile(string fileName)
        {
            //Filename pattern: XX_(MapName).att

            int startPosition = fileName.IndexOf('_') + 1;
            int endPosition = fileName.IndexOf('.');

            return fileName[startPosition..endPosition];
        }
    }
}
