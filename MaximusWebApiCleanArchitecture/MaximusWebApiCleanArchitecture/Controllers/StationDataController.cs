using Application.Features.StationDataFeatures.CreateStationData;
using Application.Features.StationDataFeatures.DeleteStationData;
using Application.Features.StationDataFeatures.GetStationData;
using Application.Features.StationDataFeatures.GetStationDataByStationId;
using Application.Features.StationDataFeatures.UpdateStationData;
using Application.Features.StationFeatures.UpdateStation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MaximusWebApiCleanArchitecture.Controllers
{
    [ApiController]
    [Route("stationData")]
    public class StationDataController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StationDataController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetStationDataResponse>>> Get(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetStationDataRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpGet("stationId")]
        public async Task<ActionResult<List<GetStationDataByStationIdResponse>>> GetStationDataByStationId([FromQuery] GetStationDataByStationIdRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateStationDataResponse>> Create([FromBody] CreateStationDataRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<UpdateStationDataResponse>> Update([FromBody] UpdateStationRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult<DeleteStationDataResponse>> Delete([FromBody] DeleteStationDataRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
