using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationDataFeatures.UpdateStationData
{
    public sealed class UpdateStationDataMapper : Profile
    {
        public UpdateStationDataMapper()
        {
            CreateMap<UpdateStationDataRequest, StationData>();
            CreateMap<StationData, UpdateStationDataResponse>();
        }
    }
}
