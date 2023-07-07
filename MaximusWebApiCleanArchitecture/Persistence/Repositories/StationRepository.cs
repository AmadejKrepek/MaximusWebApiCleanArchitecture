using Application.Common.Exceptions;
using Application.Features.StationFeatures.GetStationById;
using Application.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class StationRepository : BaseRepository<Station>, IStationRepository
    {
        public StationRepository(StationContext context) : base(context)
        {
            
        }

        public async Task<Station> GetStationByName(GetStationByNameRequest request, CancellationToken cancellationToken)
        {
            return await Context.Stations.FirstOrDefaultAsync(x => x.Name == request.Name, cancellationToken);
        }

        public void CreateIfNotExists(Station station)
        {
            if (Context.Stations.Any(x => x.Name == station.Name))
            {
                throw new BadRequestException("This station already exists");
            }

            station.StationData = new List<StationData>();

            station.DateCreated = DateTimeOffset.UtcNow;
            Context.Add(station);
        }
    }
}
