using System;
using Microsoft.AspNetCore.Identity;
using Organigrama.Models.EntityBase;

namespace Organigrama.Models
{
    public class User: EntityBase.EntityBase
    {   
        public string Name { get; set; }
    }
}
