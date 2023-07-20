using Domain.Common.Stations;

namespace Application.Features.StationFeatures.GetAllStation
{
    public sealed record GetAllStationResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public double? Altitude { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
