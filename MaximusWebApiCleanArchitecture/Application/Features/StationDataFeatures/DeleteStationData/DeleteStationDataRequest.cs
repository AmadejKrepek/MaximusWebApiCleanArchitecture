using MediatR;

namespace Application.Features.StationDataFeatures.DeleteStationData
{
    public sealed record DeleteStationDataRequest(string Id) : IRequest<DeleteStationDataResponse>;
}
