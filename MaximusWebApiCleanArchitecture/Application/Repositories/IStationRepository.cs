using Domain.Entities;

namespace Application.Repositories
{
    public interface IStationRepository : IBaseRepository<Station>
    {
        void CreateIfNotExists(Station station);
        Task<Station> GetStationByName(string name, CancellationToken cancellationToken);
    }
}
