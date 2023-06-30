﻿using Application.Common.Exceptions;
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

        public async Task<Station> GetStationByName(string name, CancellationToken cancellationToken)
        {
            return await Context.Stations.FirstOrDefaultAsync(x => x.Name == name, cancellationToken);
        }

        public void CreateIfNotExists(Station station)
        {
            if (Context.Stations.Any(x => x.Name == station.Name))
            {
                throw new BadRequestException("This station already exists");
            }

            station.StationData = new StationData();

            station.DateCreated = DateTimeOffset.UtcNow;
            Context.Add(station);
        }
    }
}
