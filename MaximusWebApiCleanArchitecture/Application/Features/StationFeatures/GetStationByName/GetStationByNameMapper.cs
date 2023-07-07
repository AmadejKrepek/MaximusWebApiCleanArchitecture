using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationFeatures.GetStationById
{
    public sealed class GetStationByNameMapper : Profile
    {
        public GetStationByNameMapper()
        {
            CreateMap<Station, GetStationByNameResponse>();
        }
    }
}
