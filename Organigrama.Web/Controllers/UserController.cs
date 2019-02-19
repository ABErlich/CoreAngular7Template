using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Organigrama.Interfaces.Mappers;

namespace Organigrama.Web.Controllers
{

    [Route("api/[controller]")]
    [Authorize]
    public class UserController: Controller
    {
		IUserMap userMap;

        public UserController(IUserMap map)
        {
            userMap = map;
        }

        [HttpGet("{id}")]
        public string Get(int id){
            return "value";
        }

        [HttpPost]public void Post([FromBody]string user){
            
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string user){
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id){
            
        }
    }
}
