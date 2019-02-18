using System;
using System.Collections.Generic;

namespace Organigrama.Interfaces.Services
{
    public interface IBaseService<T>
    {
        T Create(T domain);

        bool Update(T domain);

        bool Delete(int id);

        List<T> GetAll();

    }
}
