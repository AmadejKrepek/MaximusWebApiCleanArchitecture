using Domain.Common.Stations;
using MediatR;

namespace Application.Features.StationFeatures.UpdateStation
{
    public sealed record UpdateStationRequest(
        string Id, 
        string Name,
        float Latitude,
        float Longitude,
        double Altitude,
        ConnectionStatus ConnectionStatus,
        DateTimeOffset LastUpdated,
        UnitOfMeasurement UnitOfMeasurement
        ) 
       : IRequest<UpdateStationResponse>;
}
