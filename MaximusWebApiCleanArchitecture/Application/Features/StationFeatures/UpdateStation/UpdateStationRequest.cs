using MediatR;

namespace Application.Features.StationFeatures.UpdateStation
{
    public sealed record UpdateStationRequest(string Id, string Name) : IRequest<UpdateStationResponse>;
}
