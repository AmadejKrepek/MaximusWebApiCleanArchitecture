using Application.Features.StationFeatures.CreateStation;
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

/*        [HttpGet]
        public async Task<ActionResult<List<GetAllUserResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
            return Ok(response);
        }*/

        [HttpPost]
        public async Task<ActionResult<CreateStationResponse>> Create(CreateStationRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
