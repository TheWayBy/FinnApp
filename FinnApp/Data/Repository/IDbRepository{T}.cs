using FinnApp.Data.Repository.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FinnApp.Data.Repository
{
    public interface IDbRepository<TEntity>
        where TEntity : class, IDeletableEntity, IIdentifierableEntity
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> AllWithDeleted();

        TEntity GetByIdentifier(Guid identifier);

        void Add(TEntity entity);

        void Update(TEntity entity);

        Task<int> SaveChangesAsync();

        void Delete(TEntity entity);

        void HardDelete(TEntity entity);

        void Undelete(TEntity entity);
    }
}