using Application.Features.StationFeatures.CreateStation;
using Application.Features.StationFeatures.DeleteStation;
using Application.Features.StationFeatures.GetAllStation;
using Application.Features.StationFeatures.GetStationById;
using Application.Features.StationFeatures.UpdateStation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MaximusWebApiCleanArchitecture.Controllers
{
    [ApiController]
    [Route("station")]
    public class StationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllStationResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllStationRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpGet("name")]
        public async Task<ActionResult<GetStationByNameResponse>> GetByName([FromQuery] string name, 
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetStationByNameRequest(name), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateStationResponse>> Create(CreateStationRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<UpdateStationResponse>> Update([FromBody] UpdateStationRequest request, 
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<DeleteStationResponse>> Delete([FromBody] DeleteStationRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
