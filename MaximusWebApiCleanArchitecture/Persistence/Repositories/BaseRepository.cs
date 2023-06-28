using Application.Common.Exceptions;
using Application.Repositories;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly StationContext Context;

        public BaseRepository(StationContext context)
        {
            Context = context;
        }

        public void Create(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            Context.Add(entity);
        }

        public void Delete(T entity)
        {
            if (Context.Set<T>().Any(e => e.Id == entity.Id))
            {
                entity.DateDeleted = DateTimeOffset.UtcNow;
                Context.Update(entity);
            }
            else
            {
                throw new BadRequestException("Entity does not exist.");
            }
        }

        public Task<T> Get(Guid id, CancellationToken cancellationToken)
        {
            return Context
                .Set<T>()
                .Where(x => x.DateDeleted == null)
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return Context
                .Set<T>()
                .Where(x => x.DateDeleted == null)
                .ToListAsync(cancellationToken);
        }

        public void Update(T entity)
        {
            if (Context.Set<T>().Any(e => e.Id == entity.Id))
            {
                entity.DateUpdated = DateTimeOffset.UtcNow;
                Context.Update(entity);
            }
            else
            {
                throw new BadRequestException("Entity does not exist.");
            }
        }

        public void UpdateById(string id, T entity)
        {
            entity.Id = Guid.Parse(id);
            Context.Update(entity);
        }
    }
}
