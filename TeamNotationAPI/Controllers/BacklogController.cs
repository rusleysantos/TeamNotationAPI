using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using TeamNotationAPI.Models;

namespace TeamNotationAPI.Controllers
{
    public class BacklogController : Controller
    {
        private IBacklogService _service { get; set; }
        public BacklogController(IBacklogService service)
        {
            _service = service;
        }

        [HttpPost("[action]")]
        public IActionResult AddBacklog([FromBody] Backlog backlog)
        {
            try
            {

                return Ok(new MessageReturn("Objeto Retornado Com Sucesso",
                                            "",
                                            true,
                                            _service.AddBacklog(backlog)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar Backlog",
                                                    "Erro ao adicionar backlog, por favor tente noavmente mais tarde",
                                                    false));
            }
        }

        [HttpPut("[action]")]
        public IActionResult PutBacklog([FromBody] Backlog backlog)
        {
            try
            {
                if (_service.PutBacklog(backlog))
                {
                    return Ok(new MessageReturn("Sucesso ao Alterar Backlog",
                                                "Muito bom, sempre mantenha seus dados atualizados!",
                                                true));
                }
                else
                {
                    return Ok(new MessageReturn("Endeço Não Encontrado",
                                                "Erro ao alterar backlog, não foi encontrado.",
                                                false));

                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Alterar Backlog",
                                                     "Erro ao alterar backlog, por favor tente noavmente mais tarde.",
                                                     false));

            }
        }

        [HttpGet("[action]")]
        public IActionResult GetAdresses([FromQuery] int page, int size)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Backlogs",
                                            "",
                                            true,
                                             _service.GetBacklog(page, size)));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Backlogs",
                                                   "Erro ao consultar backlogs, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpGet("[action]")]
        public IActionResult GetBacklog([FromQuery] int idBacklog)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Backlog",
                                            "",
                                            true,
                                            _service.GetBacklog(idBacklog)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Backlogs",
                                                    "Erro ao consultar backlogs, por favor tente noavmente mais tarde.",
                                                    false));
            }
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteBacklog([FromQuery] int idBacklog)
        {
            if (_service.DeleteBacklog(idBacklog))
            {
                return Ok(new MessageReturn("Sucesso ao Deletar Backlog",
                                            "Matenha seu backlog atualizado",
                                            true));
            }
            else
            {
                return Ok(new MessageReturn("Endeço Não Encontrado",
                                            "Erro ao deletar backlog.",
                                            false));

            }
        }
    }
}
