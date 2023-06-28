namespace Application.Features.StationFeatures.GetAllStation
{
    public sealed record GetAllStationResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
