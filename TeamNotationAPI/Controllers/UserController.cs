using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using TeamAnnotationAPI.Models;

namespace TeamAnnotationAPI.Controllers
{
    [Route("api")]
    public class UserController : Controller
    {

        private IUserService _service { get; set; }
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetUserAll([FromQuery] int page, int size)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Usuários",
                                            "",
                                            true,
                                            await _service.GetUsers(page, size)));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Usuários",
                                                   "Erro ao consultar Usuários, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }
    }
}
