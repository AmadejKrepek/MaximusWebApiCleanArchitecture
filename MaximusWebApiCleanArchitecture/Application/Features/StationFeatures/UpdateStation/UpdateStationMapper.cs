using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationFeatures.UpdateStation
{
    public sealed class UpdateStationMapper : Profile
    {
        public UpdateStationMapper()
        {
            CreateMap<UpdateStationRequest, Station>();
            CreateMap<Station, UpdateStationResponse>();
        }
    }
}
