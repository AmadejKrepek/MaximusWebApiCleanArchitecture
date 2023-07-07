using AutoMapper;
using Domain.Entities;

namespace Application.Features.StationDataFeatures.GetStationDataByStationId
{
    public sealed class GetStationDataByStationIdMapper : Profile
    {
        public GetStationDataByStationIdMapper()
        {
            CreateMap<StationData, GetStationDataByStationIdResponse>();
        }
    }
}
