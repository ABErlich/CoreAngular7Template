using System;
using System.Collections.Generic;
using Organigrama.Interfaces.Repositories;
using Organigrama.Models;

namespace Organigrama.Services
{
    public class UserService: BaseService<User>
    {

        public UserService(IUserRepository userRepository) {
            base.repository = userRepository;
        }

        //public User Create(User domain){
        //    return repository.Save(domain);
        //}

        //public bool Update(User domain){
        //    return repository.Update(domain);
        //}

        //public bool Delete(int id){
        //    return repository.Delete(id);
        //}

        //public List<User> GetAll(){
        //    return repository.GetAll();
        //}
    }
}
