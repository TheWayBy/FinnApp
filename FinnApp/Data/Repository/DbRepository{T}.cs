using FinnApp.Data.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FinnApp.Data.Repository
{
    public class DbRepository<TEntity> : IDbRepository<TEntity>
        where TEntity : class, IDeletableEntity, IIdentifierableEntity
    {
        public DbRepository(ApplicationDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
            this.DbSet = this.Context.Set<TEntity>();
        }

        protected DbSet<TEntity> DbSet { get; set; }

        protected ApplicationDbContext Context { get; set; }

        public IQueryable<TEntity> All() => this.DbSet.Where(x => !x.IsDeleted);

        public IQueryable<TEntity> AllWithDeleted() => this.All();

        public TEntity GetByIdentifier(Guid identifier) => this.DbSet.FirstOrDefault(x => x.Identifier == identifier);

        public void Add(TEntity entity) => this.DbSet.Add(entity);

        public void Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public Task<int> SaveChangesAsync() => this.Context.SaveChangesAsync();

        public void HardDelete(TEntity entity) => this.DbSet.Remove(entity);

        public void Undelete(TEntity entity)
        {
            entity.IsDeleted = false;
            entity.DeletedOn = null;
            this.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.UtcNow;
            this.Update(entity);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}