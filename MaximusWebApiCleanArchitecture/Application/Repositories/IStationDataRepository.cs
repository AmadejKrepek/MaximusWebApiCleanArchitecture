using Application.Features.StationDataFeatures.GetStationDataByStationId;
using Domain.Entities;

namespace Application.Repositories
{
    public interface IStationDataRepository : IBaseRepository<StationData>
    {
        Task<List<StationData>> GetStationDataByStationId(GetStationDataByStationIdRequest request, CancellationToken cancellationToken);
    }
}
