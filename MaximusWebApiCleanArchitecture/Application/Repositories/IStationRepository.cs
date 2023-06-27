using Domain.Entities;

namespace Application.Repositories
{
    public interface IStationRepository : IBaseRepository<Station>
    {
        Task<Station> GetStationByName(string name, CancellationToken cancellationToken);
    }
}
