using Domain.Common.Stations.Units;

namespace Domain.Common.Stations.Altitude
{
    public class StationAltitude
    {
        public double Value { get; }
        public AltitudeUnit Units { get; }

        public StationAltitude(double value, AltitudeUnit units)
        {
            Value = value;
            Units = units;
        }
    }
}
