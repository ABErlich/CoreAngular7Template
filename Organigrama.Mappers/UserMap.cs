using System;
using Organigrama.Models;
using Organigrama.ViewModels;

namespace Organigrama.Mappers
{
    public class UserMap: IUserMap
    {
        IUserService userService;

        public UserMap(IUserService service){
            userService = service;
        }

        public UserViewModel Create(UserViewModel viewModel){
            UserMap user = ViewModelToDomain(viewModel);
            return DomainToViewModel(userService.Create(user));
        }

        public bool Update(UserViewModel viewModel){
            UserMap user = ViewModelToDomain(viewModel);
            return userService.Update(user);
        }

        public bool Delete(int id){
            return userService.Delete(id);
        }

        public List<UserViewModel> GetAll(){
            return DomainToViewModel(userService.GetAll());
        }

        public UserViewModel DomainToViewModel(UserMap domain){
            UserViewModel model = new UserViewModel();

            model.username = domain.Name;

            return model;
        }

        public List<UserViewModel> DomainToViewModel(List<User> domain){
            List<UserViewModel> model = new List<UserViewModel>();

            foreach(User user in domain){
                model.Add(DomainToViewModel(user));
            }

            return model;
        }

        public User ViewModelToDomain(UserViewModel userViewModel){
            User domain = new User();

            domain.Name = userViewModel.username;

            return domain;
        }

    }
}
