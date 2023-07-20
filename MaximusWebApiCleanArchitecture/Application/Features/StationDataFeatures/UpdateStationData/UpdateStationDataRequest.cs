using MediatR;

namespace Application.Features.StationDataFeatures.UpdateStationData
{
    public sealed record UpdateStationDataRequest(
        Guid Id,
        Guid StationId,
        double? Temperature,
        double? Dewpoint,
        double? Humidty,
        double? WindSpeed,
        double? WindGust,
        int? WindDirection,
        double? DailyRain,
        double? WeeklyRain,
        double? MonthlyRain,
        double? SolarRadiation
        )
       : IRequest<UpdateStationDataResponse>;
}
