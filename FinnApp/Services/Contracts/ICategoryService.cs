using FinnApp.Models;
using System;
using System.Collections.Generic;

namespace FinnApp.Services.Contracts
{
    interface ICategoryService
    {
        IList<Category> All();

        IList<Category> AllWithDeleted();

        Category Insert(Category entity);

        void Update(Category entity);

        void Delete(Guid identifier);

        void Undelete(Guid identifier);
    }
}
