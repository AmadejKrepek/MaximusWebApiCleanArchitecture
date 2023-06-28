using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationFeatures.DeleteStation
{
    public sealed class DeleteStationMapper : Profile
    {
        public DeleteStationMapper()
        {
            CreateMap<DeleteStationRequest, Station>();
            CreateMap<Station, DeleteStationResponse>();
        }
    }
}
