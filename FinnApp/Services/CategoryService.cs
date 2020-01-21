using FinnApp.Data.Repository;
using FinnApp.Models;
using FinnApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinnApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IDbRepository<Category> dbRepository;

        public CategoryService(IDbRepository<Category> dbRepository)
        {
            this.dbRepository = dbRepository;
        }

        public IList<Category> All()
        {
            return this.dbRepository.All().ToList();
        }

        public IList<Category> AllWithDeleted()
        {
            return this.dbRepository.AllWithDeleted().ToList();
        }

        public void Delete(Guid identifier)
        {
            Category entityToDelete = this.dbRepository.GetByIdentifier(identifier);

            this.dbRepository.Delete(entityToDelete);
        }

        public Category Insert(Category entity)
        {
            this.dbRepository.Add(entity);
            return entity;
        }

        public void Undelete(Guid identifier)
        {
            Category entityToUnDelete = this.dbRepository.GetByIdentifier(identifier);

            this.dbRepository.Undelete(entityToUnDelete);
        }

        public void Update(Category entity)
        {
            Category existingEntity = this.dbRepository.GetByIdentifier(entity.Identifier);
            existingEntity.Name = entity.Name;
            this.dbRepository.Update(existingEntity);
        }
    }
}
