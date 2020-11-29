using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.DTO;
using Service.Contracts;
using TeamNotationAPI.Models;

namespace TeamNotationAPI.Controllers
{
    [Route("api")]
    public class ExecutionTaskController : Controller
    {
        private IExecutionTaskService _service { get; }
        public ExecutionTaskController(IExecutionTaskService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetTasksProject([FromQuery] int idProject, int page, int size)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Buscar Projetos",
                                            "",
                                            true,
                                            await _service.GetTasksProject(idProject, page, size)));


            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Buscar Projeto",
                                                   "Erro ao buscar projeto, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> AddTaskProject([FromBody] ExecutionTaskDTO task)
        {

            try
            {
                var identity = User.Identity as ClaimsIdentity;
                task.idUser = Convert.ToInt32(identity.Claims.ToList()[1].Value);

                _service.AddExecutionTask(task);

                return Ok(new MessageReturn("Sucesso ao Adicionar Tarefa",
                                            "Tarefa adiciona com sucesso",
                                            true));
            }
            catch (Exception e)
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar Tarefa",
                                                   "Erro ao cadastrar item.",
                                                   false));

            }
        }
    }
}
