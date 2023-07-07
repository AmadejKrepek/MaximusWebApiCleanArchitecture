using Domain.Entities;

namespace Application.Features.StationDataFeatures.GetStationDataByStationId
{
    public sealed record GetStationDataByStationIdResponse
    {
        public double? Temperature { get; set; }
        public double? Dewpoint { get; set; }
        public double? Humidity { get; set; }
        public double? WindSpeed { get; set; }
        public double? WindGust { get; set; }
        public int? WindDirection { get; set; }
        public double? DailyRain { get; set; }
        public double? SolarRadiation { get; set; }
    }
}
