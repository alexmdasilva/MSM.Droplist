using Application.Commands.ImportMapDropFile;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("v1/mapdrop")]
    public class MapDropController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MapDropController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost("import")]
        public async Task<IActionResult> ImportMapDropFile(List<IFormFile> mapDropFiles)
        {
            int count = 0;

            foreach (var file in mapDropFiles)
            {
                await _mediator.Send(new ImportMapDropFileCommandInput(file));
                count++;
            }

            return Created("v1/mapdrop/import", new { FileCount = count });
        }
    }
}
