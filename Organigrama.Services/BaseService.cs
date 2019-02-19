using System;
using System.Collections.Generic;
using Organigrama.Interfaces.Repositories;
using System.Linq;
using Organigrama.Interfaces.Services;

namespace Organigrama.Services
{
    public class BaseService<T>: IBaseService<T>
    {
        protected IBaseRepository<T> repository;

        public void Create(T domain)
        {
            repository.Save(domain);
        }

        public bool Update(T domain)
        {
            return repository.Update(domain);
        }

        public void Delete(int id)
        {
            T domain = repository.GetById(id);

            if(domain != null){
                repository.Delete(domain);    
            }
        }

        public void Delete(T domain)
        {
            repository.Delete(domain);
        }

        public List<T> GetAll()
        {
            return repository.GetAll().ToList();
        }

        public T GetById(int id){
            return repository.GetById(id);
        }
    }
}
