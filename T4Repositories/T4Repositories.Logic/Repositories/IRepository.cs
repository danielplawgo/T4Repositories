using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4Repositories.Models;

namespace T4Repositories.Logic.Repositories
{
    public interface IRepository<T> where T : BaseModel, new()
    {
        void Add(T entity);

        void Delete(T entity);

        void Delete(int id);

        T GetById(int id);

        IQueryable<T> GetAllActive();

        IQueryable<T> GetAll();

        void SaveChanges();
    }
}
