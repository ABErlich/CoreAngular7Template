using System;
using Organigrama.Interfaces.Repositories;
using Organigrama.Models;
using Organigrama.Models.Context;

namespace Organigrama.Repositories
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(IApplicationContext context): base(context){}

        //public User Save(User domain){
        //    try{
        //        var us = InserUser<User>(domain);
        //        return us;
        //    } catch (Exception ex){
        //        // handle
        //        throw ex;
        //    }
        //}

        //public bool Update(User domain){
        //    try {
        //        //domain.Updated = DateTime.Now;
        //        UpdateUser<User>(domain);
        //        return true;
        //    } catch (Exception ex) {
        //        //ErrorManager.ErrorHandler.HandleError(ex);
        //        throw ex;
        //    }

        //}

        //public bool Delete(int id) {
        //    try{
        //        User user = Context.UsersDB.Where(x => x.Id.Equals(id)).FirstOrDefault();
        //        if (user != null) {
        //            //Delete<User>(user);
        //            return true;
        //        } else {
        //            return false;
        //        }
        //    } catch (Exception ex) {
        //        //ErrorManager.ErrorHandler.HandleError(ex);
        //        throw ex;
        //    }
        //}

        //public List<User> GetAll()
        //{
        //    try {
        //        return Context.UsersDB.OrderBy(x => x.Name).ToList();
        //    } catch (Exception ex) {
        //        //ErrorManager.ErrorHandler.HandleError(ex);
        //        throw ex;
        //    }

        //}
    }
}
