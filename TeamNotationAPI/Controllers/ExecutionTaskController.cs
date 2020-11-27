using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace TeamNotationAPI.Controllers
{
    [Route("api")]
    public class ExecutionTaskController : Controller
    {
        private ITaskService _service { get; }
        public ExecutionTaskController(ITaskService service)
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





    }
}
