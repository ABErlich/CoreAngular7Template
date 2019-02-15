using System;
using System.Collections.Generic;

namespace Organigrama.Interfaces.Repositories
{
    public interface IBaseRepository<T>
    {
        T Save(T domain);
        bool Update(T domain);
        bool Delete(int id);
        List<T> GetAll();
    }
}
