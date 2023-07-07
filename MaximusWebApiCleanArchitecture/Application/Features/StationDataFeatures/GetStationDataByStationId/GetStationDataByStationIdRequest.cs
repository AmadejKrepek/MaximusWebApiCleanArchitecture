using MediatR;

namespace Application.Features.StationDataFeatures.GetStationDataByStationId
{
    public sealed record GetStationDataByStationIdRequest(Guid stationId) : IRequest<List<GetStationDataByStationIdResponse>>;
}
