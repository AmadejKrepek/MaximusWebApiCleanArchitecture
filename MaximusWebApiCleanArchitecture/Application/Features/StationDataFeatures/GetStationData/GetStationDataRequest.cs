using MediatR;

namespace Application.Features.StationDataFeatures.GetStationData
{
    public sealed record GetStationDataRequest : IRequest<List<GetStationDataResponse>>;
}
