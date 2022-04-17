using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using TeamAnnotationAPI.Models;

namespace TeamAnnotationAPI.Controllers
{
    [Route("api")]
    public class ProjectController : Controller
    {
        private IProjectService _service { get; set; }

        public ProjectController(IProjectService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetProjectOptions()
        {
            var identity = User.Identity as ClaimsIdentity;

            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Options",
                                            "",
                                            true,
                                            await _service.GetProjectOptions(Convert.ToInt32(identity.Claims.ToList()[1].Value))));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Status",
                                                   "Erro ao consultar status, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> AddProject([FromBody] Project project)
        {
            var identity = User.Identity as ClaimsIdentity;

            try
            {
                if (ModelState.IsValid)
                {
                    return Ok(new MessageReturn("Sucesso ao Adicionar Projeto",
                                                "",
                                                true,
                                                await _service.AddProject(project, Convert.ToInt32(identity.Claims.ToList()[1].Value))));

                }
                else
                {
                    return BadRequest(new MessageReturn("Erro ao Adicionar Projeto",
                                                        "Preencha todos os campos.",
                                                        false));
                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar Projeto",
                                                    "Erro ao adicionar projeto, por favor tente noavmente mais tarde.",
                                                    false));

            }
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetProject([FromQuery] int idProject)
        {

            try
            {

                return Ok(new MessageReturn("Sucesso ao Buscar Projetos",
                                            "",
                                            true,
                                            await _service.GetProject(idProject)));


            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Buscar Projeto",
                                                   "Erro ao buscar projeto, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

 



    }
}
