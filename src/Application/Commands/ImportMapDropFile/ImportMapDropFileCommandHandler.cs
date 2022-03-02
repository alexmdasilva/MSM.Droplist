using Application.Services;
using Domain.Data;
using Domain.Entities;
using MediatR;

namespace Application.Commands.ImportMapDropFile
{
    public class ImportMapDropFileCommandHandler : IRequestHandler<ImportMapDropFileCommandInput, ImportMapDropFileCommandResult>
    {
        private readonly IMapDropRepository _mapDropRepository;
        private readonly IXmlDeserializer _xmlDeserializer;

        public ImportMapDropFileCommandHandler(IMapDropRepository mapDropRepository, IXmlDeserializer xmlDeserializer)
        {
            _mapDropRepository = mapDropRepository ?? throw new ArgumentNullException(nameof(mapDropRepository));
            _xmlDeserializer = xmlDeserializer ?? throw new ArgumentNullException(nameof(xmlDeserializer));
        }

        public async Task<ImportMapDropFileCommandResult> Handle(ImportMapDropFileCommandInput request, CancellationToken cancellationToken)
        {
            var stream = new MemoryStream();

            await request.File.CopyToAsync(stream, cancellationToken);

            var deserializedMapDrop = _xmlDeserializer.DeserializeXml<MapDropDeserializedItem>(stream);

            if (deserializedMapDrop is null)
                return new ImportMapDropFileCommandResult();

            var mapDrop = new MapDrop(
                mapId: ExtractMapIdFromFileName(request.File.FileName),
                totalRate: deserializedMapDrop.ItemDrop.Sum(itemDrop => itemDrop.Rate),
                itemDrops: deserializedMapDrop.ItemDrop.Select(
                    itemDrop => new ItemDrop(
                        itemDrop.MonsterID,
                        itemDrop.Cat,
                        itemDrop.Index,
                        itemDrop.Skill,
                        itemDrop.Luck,
                        itemDrop.Exc,
                        itemDrop.Rate,
                        itemDrop.Name)).ToList());

            await _mapDropRepository.Add(mapDrop);

            await _mapDropRepository.UnitOfWork.CommitAsync();

            return new ImportMapDropFileCommandResult(mapDrop.Id);
        }

        private static int ExtractMapIdFromFileName(string fileName)
        {
            return Convert.ToInt32(new string(fileName.Where(char.IsDigit).ToArray()));
        }
    }
}
