using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.ImportMapDropFile
{
    public class ImportMapDropFileCommandInput : IRequest<ImportMapDropFileCommandResult>
    {
        public ImportMapDropFileCommandInput(IFormFile file)
        {
            File = file;
        }

        public IFormFile File { get; }
    }
}
