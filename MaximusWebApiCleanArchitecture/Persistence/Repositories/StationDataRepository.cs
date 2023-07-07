using Application.Features.StationDataFeatures.GetStationDataByStationId;
using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class StationDataRepository : BaseRepository<StationData>, IStationDataRepository
    {
        public StationDataRepository(StationContext context) : base(context)
        {

        }

        public async Task<List<StationData>> GetStationDataByStationId(GetStationDataByStationIdRequest request, CancellationToken cancellationToken)
        {
            return await Context.StationData
                .Where(x => x.StationId == request.stationId)
                .ToListAsync();
        }
    }
}
