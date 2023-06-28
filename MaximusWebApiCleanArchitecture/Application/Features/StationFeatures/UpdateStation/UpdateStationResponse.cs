using Domain.Common.Stations;

namespace Application.Features.StationFeatures.UpdateStation
{
    public class UpdateStationResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public double? Altitude { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
