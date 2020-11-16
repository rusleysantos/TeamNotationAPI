using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using TeamNotationAPI.Models;

namespace TeamNotationAPI.Controllers
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
        //[Authorize]
        public async Task<IActionResult> GetProjectOptions()
        {
            var stream = "[encoded jwt]";
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = handler.ReadToken(stream) as JwtSecurityToken;

            try
            {
                return Ok("");
                //int idUser = Convert.ToInt32(tokenS.Claims.First(claim => claim.Type == "idUser").Value);

                //return Ok(new MessageReturn("Sucesso ao Consultar Options",
                //                            "",
                //                            true,
                //                             await _service.GetProjectOptions(idUser)));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Status",
                                                   "Erro ao consultar status, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddProject([FromBody] Project project)
        {

            try
            {
                _service.AddProject(project);

                return Ok(new MessageReturn("Sucesso ao Adicionar Projeto",
                                            "",
                                            true,
                                             ""));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar Projeto",
                                                   "Erro ao adicionar projeto, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }


    }
}
