using MediatR;

namespace Application.Features.StationFeatures.DeleteStation
{
    public sealed record DeleteStationRequest(string Id) : IRequest<DeleteStationResponse>;
}
