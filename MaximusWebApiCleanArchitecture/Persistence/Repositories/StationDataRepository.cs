using Application.Repositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class StationDataRepository : BaseRepository<StationData>, IStationDataRepository
    {
        public StationDataRepository(StationContext context) : base(context)
        {

        }
    }
}
