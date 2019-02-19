using System;
using System.Collections.Generic;
using System.Linq;

namespace Organigrama.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        void Save(T domain);
        bool Update(T domain);
        void Delete(T domain);
        IQueryable<T> GetAll();
        T GetById(int id);
    }
}
