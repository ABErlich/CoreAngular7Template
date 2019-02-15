using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Organigrama.ViewModels;

namespace Organigrama.Web.Controllers
{
    [Route("api/Token")]
    public class TokenController
    {

        private IConfiguration _config;

        public TokenController(IConfiguration config)
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public dynamic Post([FromBody]LoginViewmodel login){
            IActionResult response = new UnauthorizedResult();

            var user = Authenticate(login);
            if(user != null){
                var tokenString = BuildToken(user);
                response = new OkResult(tokenString);
            }

            return response;
        }

        private string BuildToken(UserViewModel user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              expires: DateTime.Now.AddMinutes(30),
              signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserViewModel Authenticate(LoginViewmodel login){
            UserViewModel user = null;

            if(login.username == "pablo" && login.password == "secret"){
                user = new UserViewModel { username = "Pablo" };
            }

            return user;
        }

    }
}
