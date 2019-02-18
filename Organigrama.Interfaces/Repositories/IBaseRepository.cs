using System;
using System.Collections.Generic;
using System.Linq;

namespace Organigrama.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        T Save(T domain);
        bool Update(T domain);
        bool Delete(int id);
        IQueryable<T> GetAll();
    }
}
