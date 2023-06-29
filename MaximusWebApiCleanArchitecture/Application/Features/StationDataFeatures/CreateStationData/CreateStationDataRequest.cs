﻿using Domain.Entities;
using MediatR;

namespace Application.Features.StationDataFeatures.CreateStationData
{
    public sealed record CreateStationDataRequest(
        double? Temperature,
        double? Dewpoint,
        double? Humidity,
        double? WindSpeed,
        double? WindGust,
        int? WindDirection,
        double? DailyRain,
        double? SolarRadiation,
        Station? Station
     ) : IRequest<CreateStationDataResponse>;
}
