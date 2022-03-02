using API.Requests.MapList;
using Application.Commands.AddMap;
using Application.Commands.ImportMapListFile;
using Application.Queries.GetMapList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("v1/maplist")]
    public class MapController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MapController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMaps()
        {
            var result = await _mediator.Send(new GetMapListQueryInput());

            if (!result.Maps.Any())
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddMap(AddMapRequest input)
        {
            var addMapCommandInput = new AddMapCommandInput(input.Number, input.Name);

            var result = await _mediator.Send(addMapCommandInput);

            return Created("v1/maplist/", result);
        }

        [HttpPost("import")]
        public async Task<IActionResult> UploadMapListFile(IFormFile file)
        {
            var importFileCommandInput = new ImportMapListFileCommandInput(file);

            var result = await _mediator.Send(importFileCommandInput);

            return Created("v1/maplist/import", result);
        }
    }
}
