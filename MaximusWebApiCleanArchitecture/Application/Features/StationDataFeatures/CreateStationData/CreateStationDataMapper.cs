using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationDataFeatures.CreateStationData
{
    public sealed class CreateStationDataMapper : Profile
    {
        public CreateStationDataMapper()
        {
            CreateMap<CreateStationDataRequest, StationData>();
            CreateMap<StationData, CreateStationDataResponse>();
        }
    }
}
