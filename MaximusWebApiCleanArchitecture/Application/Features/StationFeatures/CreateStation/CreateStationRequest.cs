using Domain.Common.Stations;
using MediatR;

namespace Application.Features.StationFeatures.CreateStation
{
    public sealed record CreateStationRequest(
        string Name,
        float? Latitude,
        float? Longitude,
        double? Altitude,
        ConnectionStatus ConnectionStatus,
        DateTimeOffset? LastUpdated,
        UnitOfMeasurement UnitOfMeasurement)
    : IRequest<CreateStationResponse>;
}
