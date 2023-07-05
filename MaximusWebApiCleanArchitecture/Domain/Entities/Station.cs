using Domain.Common;
using Domain.Common.Stations;

namespace Domain.Entities
{
    public class Station : BaseEntity
    {
        public string? Name { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public double? Altitude { get; set; }
        public ConnectionStatus ConnectionStatus { get; set; }
        public DateTimeOffset? LastUpdated { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public StationData StationData { get; set; }
    }
}
