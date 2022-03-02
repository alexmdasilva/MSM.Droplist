using Application.Commands.ImportMonsterListFile;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("v1/monsters")]
    public class MonsterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MonsterController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost("import")]
        public async Task<IActionResult> UploadMonsterListFile(IFormFile file)
        {
            var result = await _mediator.Send(new ImportMonsterListFileCommandInput(file));

            return Created("v1/monsters/import", result);
        }
    }
}
