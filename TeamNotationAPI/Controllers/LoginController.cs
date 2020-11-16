using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth.Contracts;
using Domain.Domains;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Service.Contracts;

namespace TeamNotationAPI.Controllers
{
    [Route("api")]
    public class LoginController : Controller
    {
        private ILoginService _service { get; set; }
        private ITokenService _token { get; set; }
    
        public LoginController(ILoginService service, ITokenService token)
        {
            _service = service;
            _token = token;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            try
            {
                Login LoginReturn = _service.Login(login).Result;

                if (LoginReturn.AuthorizationStatus)
                {

                    return Ok(new MessageReturn("Login Efetuado Com Sucesso",
                                                _token.GenerateToken(LoginReturn),
                                                true));
                }
                else
                {
                    return Ok(new MessageReturn("Senha ou Login Errado",
                                                "",
                                                false));
                }
            }
            catch(Exception e)
            {
                return BadRequest(new MessageReturn("Erro ao Fazer Login",
                                                     "Erro ao realizar login, por favor tente mais tarde.",
                                                     false));
            }
        }
    }
}
