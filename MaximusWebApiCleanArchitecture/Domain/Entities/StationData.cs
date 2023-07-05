using Domain.Common;

namespace Domain.Entities
{
    public class StationData : BaseEntity
    {
        public double? Temperature { get; set; }
        public double? Dewpoint { get; set; }
        public double? Humidity { get; set; }
        public double? WindSpeed { get; set; }
        public double? WindGust { get; set; }
        public int? WindDirection { get; set; }
        public double? DailyRain { get; set; }
        public double? SolarRadiation { get; set; }

        public Guid StationId { get; set; }
        public Station Station { get; set; }
    }
}
