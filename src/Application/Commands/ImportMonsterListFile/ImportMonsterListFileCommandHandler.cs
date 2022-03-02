using Application.Services;
using Domain.Data;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.ImportMonsterListFile
{
    public class ImportMonsterListFileCommandHandler : IRequestHandler<ImportMonsterListFileCommandInput, ImportMonsterListFileCommandResult>
    {
        private readonly IMonsterRepository _monsterRepository;
        private readonly IXmlDeserializer _xmlDeserializer;

        public ImportMonsterListFileCommandHandler(IMonsterRepository monsterRepository, IXmlDeserializer xmlDeserializer)
        {
            _monsterRepository = monsterRepository ?? throw new ArgumentNullException(nameof(monsterRepository));
            _xmlDeserializer = xmlDeserializer ?? throw new ArgumentNullException(nameof(xmlDeserializer));
        }

        public async Task<ImportMonsterListFileCommandResult> Handle(ImportMonsterListFileCommandInput request, CancellationToken cancellationToken)
        {
            var stream = new MemoryStream();

            await request.File.CopyToAsync(stream, cancellationToken);

            var deserializedMonsterList = _xmlDeserializer.DeserializeXml<DeserializedMonsterListFile>(stream);

            if (deserializedMonsterList is null)
                return new ImportMonsterListFileCommandResult();

            var monsters = deserializedMonsterList.Monsters
                .Select(monster => new Monster(monster.Index, monster.Name));

            foreach (var monster in monsters)
                await _monsterRepository.Add(monster);

            await _monsterRepository.UnitOfWork.CommitAsync();

            return new ImportMonsterListFileCommandResult
            {
                MonsterQuantity = monsters.Count()
            };
        }
    }
}
