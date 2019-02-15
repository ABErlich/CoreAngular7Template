using System;
using Microsoft.AspNetCore.Identity;

namespace Organigrama.Models
{
    public class User: IdentityUser
    {   
        public string Name { get; set; }
    }
}
