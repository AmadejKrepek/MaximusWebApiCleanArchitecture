using MediatR;

namespace Application.Features.StationFeatures.GetAllStation
{
    public sealed record GetAllStationRequest : IRequest<List<GetAllStationResponse>>;
}
