using System;
using System.Collections.Generic;
using Organigrama.Interfaces.Mappers;
using Organigrama.Interfaces.Services;
using Organigrama.Models;
using Organigrama.Services;
using Organigrama.ViewModels;

namespace Organigrama.Mappers
{
    public class UserMap: BaseMapper<User, UserViewModel>, IUserMap
    {
        
        IUserService userService;

        public UserMap(IUserService service){
            this.baseService = userService = service;
        }

        //public UserViewModel Create(UserViewModel viewModel){
        //    UserMap user = ViewModelToDomain(viewModel);
        //    return DomainToViewModel(userService.Create(user));
        //}

        public bool Update(UserViewModel viewModel){
            User user = ViewModelToDomain(viewModel);
            return userService.Update(user);
        }

        public void Delete(int id){
            userService.Delete(id);
        }

        public List<UserViewModel> GetAll(){
            return DomainToViewModel(userService.GetAll());
        }

        public override UserViewModel DomainToViewModel(User domain){
            UserViewModel model = new UserViewModel();

            model.username = domain.Name;

            return model;
        }

        public override User ViewModelToDomain(UserViewModel userViewModel){
            User domain = new User();

            domain.Name = userViewModel.username;

            return domain;
        }

    }
}
