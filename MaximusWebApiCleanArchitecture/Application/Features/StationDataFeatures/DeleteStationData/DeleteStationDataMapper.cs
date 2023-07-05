using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationDataFeatures.DeleteStationData
{
    public sealed class DeleteStationDataMapper : Profile
    {
        public DeleteStationDataMapper()
        {
            CreateMap<DeleteStationDataRequest, StationData>();
            CreateMap<StationData, DeleteStationDataResponse>();
        }
    }
}
