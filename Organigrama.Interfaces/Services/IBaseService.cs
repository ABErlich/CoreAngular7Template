using System;
using System.Collections.Generic;

namespace Organigrama.Interfaces.Services
{
    public interface IBaseService<T>
    {
        void Create(T domain);

        bool Update(T domain);

        void Delete(int id);

        void Delete(T domain);

        List<T> GetAll();

    }
}
