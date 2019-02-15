using System;
using System.Collections.Generic;
using Organigrama.Interfaces.Repositories;

namespace Organigrama.Services
{
    public class BaseService<T>
    {
        protected IBaseRepository<T> repository;

        public T Create(T domain)
        {
            return repository.Save(domain);
        }

        public bool Update(T domain)
        {
            return repository.Update(domain);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public List<T> GetAll()
        {
            return repository.GetAll();
        }
    }
}
