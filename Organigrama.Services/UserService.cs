using System;
using System.Collections.Generic;
using Organigrama.Interfaces.Repositories;
using Organigrama.Interfaces.Services;
using Organigrama.Models;

namespace Organigrama.Services
{
    public class UserService: BaseService<User>, IUserService
    {

        public UserService(IUserRepository userRepository) {
            base.repository = userRepository;
        }

    }
}
