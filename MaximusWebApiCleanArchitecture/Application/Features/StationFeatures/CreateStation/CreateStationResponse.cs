using Domain.Common.Stations;
using Domain.Entities;

namespace Application.Features.StationFeatures.CreateStation
{
    public sealed record CreateStationResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public double? Altitude { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
