using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4Repositories.Logic.Repositories;
using T4Repositories.Models;

namespace T4Repositories.Logic
{
    public class ProductLogic : IProductLogic
    {
        private Lazy<IProductRepository> _repository;

        protected IProductRepository Repository
        {
            get { return _repository.Value; }
        }

        public ProductLogic(Lazy<IProductRepository> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllActive()
        {
            return Repository.GetAllActive();
        }

        public Product GetById(int id)
        {
            return Repository.GetById(id);
        }

        public void Add(Product model)
        {
            Repository.Add(model);

            Repository.SaveChanges();
        }

        public void Update(Product model)
        {
            Repository.SaveChanges();
        }

        public void Delete(int id)
        {
            Repository.Delete(id);

            Repository.SaveChanges();
        }
    }
}
