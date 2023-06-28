using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationFeatures.GetAllStation
{
    public sealed class GetAllStationMapper : Profile
    {
        public GetAllStationMapper()
        {
            CreateMap<Station, GetAllStationResponse>();
        }
    }
}
