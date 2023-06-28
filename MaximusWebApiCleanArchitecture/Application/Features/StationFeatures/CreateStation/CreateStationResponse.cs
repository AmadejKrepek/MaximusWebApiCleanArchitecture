namespace Application.Features.StationFeatures.CreateStation
{
    public sealed record CreateStationResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
