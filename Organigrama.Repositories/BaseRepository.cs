using System;
using System.Collections.Generic;
using Organigrama.Models.Context;

namespace Organigrama.Repositories
{
    public class BaseRepository<T>
    {
        protected IApplicationContext context;

        public BaseRepository(IApplicationContext _context){
            context = _context;
        }

        public T Save(T domain)
        {
            try
            {
                return Insert<T>(domain);
            }
            catch (Exception ex)
            {
                // handle
                throw ex;
            }
        }

        public bool Update(T domain)
        {
            try
            {
                domain.UpdatedOn = DateTime.Now;
                Update<T>(domain);
                return true;
            }
            catch (Exception ex)
            {
                //ErrorManager.ErrorHandler.HandleError(ex);
                throw ex;
            }

        }

        public bool Delete(int id)
        {
            try
            {
                T domain = context.Set<T>.Where(x => x.Id.Equals(id)).FirstOrDefault();
                if (domain != null)
                {
                    Delete<T>(domain);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //ErrorManager.ErrorHandler.HandleError(ex);
                throw ex;
            }
        }

        public List<T> GetAll()
        {
            try
            {
                return context.Set<T>.OrderBy(x => x.Name).ToList();
            }
            catch (Exception ex)
            {
                //ErrorManager.ErrorHandler.HandleError(ex);
                throw ex;
            }

        }
    }
}
