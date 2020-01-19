using FinnApp.Data.Repository.Models;
using System.Linq;
using System.Threading.Tasks;

namespace FinnApp.Data.Repository
{
    public interface IDbRepository<TEntity>
        where TEntity : class, IDeletableEntity
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> AllWithDeleted();

        Task AddAsync(TEntity entity);

        void Update(TEntity entity);

        Task<int> SaveChangesAsync();

        void Delete(TEntity entity);

        void HardDelete(TEntity entity);

        void Undelete(TEntity entity);
    }
}