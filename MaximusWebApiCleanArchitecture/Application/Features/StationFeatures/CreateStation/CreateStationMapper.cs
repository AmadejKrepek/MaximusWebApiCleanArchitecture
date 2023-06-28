using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationFeatures.CreateStation
{
    public sealed class CreateStationMapper : Profile
    {
        public CreateStationMapper()
        {
            CreateMap<CreateStationRequest, Station>();
            CreateMap<Station, CreateStationResponse>();
        }
    }
}
