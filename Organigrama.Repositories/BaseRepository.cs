using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using Organigrama.Models;
using Organigrama.Models.Context;
using Organigrama.Models.EntityBase;

namespace Organigrama.Repositories
{
    public class BaseRepository<T> where T: EntityBase
    {
        //protected IApplicationContext context;
        protected readonly DbContext context;
        protected IDbContextTransaction contextTransaction;

        public BaseRepository(ApplicationContext _context){
            context = _context;
        }

        public DbContext GetContext()
        {
            return context;
        }

        public T Save(T domain)
        {
            try
            {
                domain.CreatedOn = DateTime.Now;
                return context.Set<T>.Add(domain);
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
                var entry = this.context.Entry(domain);
                var key = this.GetPrimaryKey(entry);
                if (entry.State == EntityState.Detached)
                {
                    var currentEntry = this.context.Set<T>().Find(key);
                    if (currentEntry != null)
                    {
                        var attachedEntry = this.context.Entry(currentEntry);
                        attachedEntry.CurrentValues.SetValues(domain);
                    }
                    else
                    {
                        this.context.Set<T>().Attach(domain);
                        entry.State = EntityState.Modified;
                    }
                }
                Update(domain);
                return true;
            }
            catch (Exception ex)
            {
                //ErrorManager.ErrorHandler.HandleError(ex);
                throw ex;
            }

        }

        public void SaveOrUpdate(T domain)
        {
            var entry = this.context.Entry(domain);
            var key = GetPrimaryKey(entry);
            if (entry.State == EntityState.Detached)
            {
                var currentEntry = this.context.Set<T>().Find(key);
                if (currentEntry != null)
                {
                    var attachedEntry = this.context.Entry(currentEntry);
                    domain.UpdatedOn = DateTime.Now;
                    attachedEntry.CurrentValues.SetValues(domain);
                }
                else
                {
                    this.context.Set<T>().Attach(domain);
                    entry.State = EntityState.Added;
                }
            }
        }

        public bool Delete(int id)
        {
            try
            {
                T domain = context.Set<T>.Where(x => x.Id.Equals(id)).FirstOrDefault();
                if (domain != null)
                {
                    Delete(id);
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

        public IQueryable<T> GetAll()
        {
            try
            {
                return context.Set<T>();
            }
            catch (Exception ex)
            {
                //ErrorManager.ErrorHandler.HandleError(ex);
                throw ex;
            }

        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        private int GetPrimaryKey(EntityEntry entry)
        {
            var myObject = entry.Entity;
            var property =
                myObject.GetType()
                     .GetProperties().FirstOrDefault(prop => Attribute.IsDefined(prop, typeof(KeyAttribute)));
            return (int)property.GetValue(myObject, null);
        }
    }
}
