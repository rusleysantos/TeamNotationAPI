using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [HttpPost("[action]")]
        public IActionResult Login(Login login)
        {
            try
            {
                if (_service.Login(login))
                {
                    return Ok("");
                }
                else
                {
                    return Ok(new MessageReturn("Senha ou Login Errado",
                                                "",
                                                false));
                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Fazer Login",
                                                     "Erro ao realizar login, por favor tente mais tarde.",
                                                     false));
            }
        }
    }
}
