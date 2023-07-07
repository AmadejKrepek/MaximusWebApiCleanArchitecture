namespace Application.Features.StationDataFeatures.UpdateStationData
{
    public class UpdateStationDataResponse
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
