using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class StationContext : DbContext
    {
        public StationContext(DbContextOptions<StationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Station>()
                .HasMany(s => s.StationData)
                .WithOne(sd => sd.Station)
                .HasForeignKey(sd => sd.StationId);
        }

        public DbSet<Station> Stations { get; set; }
        public DbSet<StationData> StationData { get; set; }
    }
}
