using MediatR;

namespace Application.Features.StationFeatures.GetStationById
{
    public sealed record GetStationByNameRequest(string Name) : IRequest<List<GetStationByNameResponse>>;
}
