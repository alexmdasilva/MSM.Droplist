using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Commands.ImportMapListFile
{
    public class ImportMapListFileCommandInput : IRequest<ImportMapListFileCommandResult>
    {
        public ImportMapListFileCommandInput(IFormFile file)
        {
            File = file;
        }

        public IFormFile File { get; }
    }
}
