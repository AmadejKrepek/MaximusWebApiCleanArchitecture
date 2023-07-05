using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationDataFeatures.GetStationData
{
    public sealed class GetStationDataMapper : Profile
    {
        public GetStationDataMapper()
        {
            CreateMap<StationData, GetStationDataResponse>();
        }
    }
}
