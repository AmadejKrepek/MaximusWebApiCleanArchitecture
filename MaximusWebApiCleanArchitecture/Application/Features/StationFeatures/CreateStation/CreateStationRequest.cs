using MediatR;

namespace Application.Features.StationFeatures.CreateStation
{
    public sealed record CreateStationRequest(string Name) : IRequest<CreateStationResponse>;
}
