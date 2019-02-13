using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Organigrama.Web.Controllers
{
    [Route("api/Token")]
    public class TokenController
    {

        private IConfiguration _config;

        public TokenController(IConfiguration config)
        {
            _config = config
        }

        [AllowAnonymous]
        [HttpPost]
        public dynamic Post([FromBody]LoginViewModel login){
            IActionResult response = UnauthorizedResult();

            var user = Authenticate(login);
            if(user != null){
                var tokenString = BuildToken(user);
                response = OkResult(new { tokenString = tokenString });
            }

            return response;
        }

        private string BuildToken(UserViewModel user){
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigninCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"]),
            _config["Jwt:Issuer"],
            expires: D
        }

    }
}
