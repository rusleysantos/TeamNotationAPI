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
    public class StatusController : Controller
    {
        private IStatusService _service { get; set; }
        public StatusController(IStatusService service)
        {
            _service = service;
        }

        [HttpPost("[action]")]
        public IActionResult AddStatus([FromBody] Status status)
        {
            try
            {

                return Ok(new MessageReturn("Objeto Retornado Com Sucesso",
                                            "",
                                            true,
                                            _service.AddStatus(status)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar Status",
                                                    "Erro ao adicionar status, por favor tente noavmente mais tarde",
                                                    false));
            }
        }

        [HttpPut("[action]")]
        public IActionResult PutStatus([FromBody] Status status)
        {
            try
            {
                if (_service.PutStatus(status))
                {
                    return Ok(new MessageReturn("Sucesso ao Alterar Status",
                                                "Muito bom, sempre mantenha seus dados atualizados!",
                                                true));
                }
                else
                {
                    return Ok(new MessageReturn("Endeço Não Encontrado",
                                                "Erro ao alterar status, não foi encontrado.",
                                                false));

                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Alterar Status",
                                                     "Erro ao alterar status, por favor tente noavmente mais tarde.",
                                                     false));

            }
        }

        [HttpGet("[action]")]
        public IActionResult GetStatus([FromQuery] int page, int size)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Statuss",
                                            "",
                                            true,
                                             _service.GetStatus(page, size)));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Statuss",
                                                   "Erro ao consultar statuss, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpGet("[action]")]
        public IActionResult GetStatus([FromQuery] int idStatus)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Status",
                                            "",
                                            true,
                                            _service.GetStatus(idStatus)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Statuss",
                                                    "Erro ao consultar statuss, por favor tente noavmente mais tarde.",
                                                    false));
            }
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteStatus([FromQuery] int idStatus)
        {
            if (_service.DeleteStatus(idStatus))
            {
                return Ok(new MessageReturn("Sucesso ao Deletar Status",
                                            "Matenha seu status atualizado",
                                            true));
            }
            else
            {
                return Ok(new MessageReturn("Endeço Não Encontrado",
                                            "Erro ao deletar status.",
                                            false));

            }
        }
    }
}
