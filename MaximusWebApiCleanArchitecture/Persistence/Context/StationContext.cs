using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class StationContext : DbContext
    {
        public StationContext(DbContextOptions<StationContext> options) : base(options)
        {

        }

        public DbSet<Station> Stations { get; set; }
    }
}
