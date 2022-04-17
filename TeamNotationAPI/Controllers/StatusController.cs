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
    public class StatusController : Controller
    {
        private IStatusService _service { get; set; }
        public StatusController(IStatusService service)
        {
            _service = service;
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> AddStatus([FromBody] Status status)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso Ao Adicionar",
                                            "",
                                            true,
                                            await _service.AddStatus(status)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar",
                                                    "Erro ao adicionar, por favor tente noavmente mais tarde",
                                                    false));
            }
        }

        [HttpPut("[action]")]
        [Authorize]
        public async Task<IActionResult> PutStatus([FromBody] Status status)
        {
            try
            {
                if (_service.PutStatus(status).Result)
                {
                    return Ok(new MessageReturn("Sucesso ao Alterar Status",
                                                "Muito bom, sempre mantenha seus dados atualizados!",
                                                true));
                }
                else
                {
                    return Ok(new MessageReturn("Status Não Encontrado",
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
        [Authorize]
        public async Task<IActionResult> GetStatusAll([FromQuery] int page, int size)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Status",
                                            "",
                                            true,
                                             await _service.GetStatus(page, size)));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Status",
                                                   "Erro ao consultar status, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetStatusAllByType([FromQuery] int page, int size, string type)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Status",
                                            "",
                                            true,
                                            await _service.GetStatusAllByType(page, size, type)));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Status",
                                                   "Erro ao consultar status, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetStatus([FromQuery] int idStatus)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Status",
                                            "",
                                            true,
                                            await _service.GetStatus(idStatus)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Status",
                                                    "Erro ao consultar statuss, por favor tente noavmente mais tarde.",
                                                    false));
            }
        }

        [HttpDelete("[action]")]
        [Authorize]
        public async Task<IActionResult> DeleteStatus([FromQuery] int idStatus)
        {
            if (_service.DeleteStatus(idStatus).Result)
            {
                return Ok(new MessageReturn("Sucesso ao Deletar Status",
                                            "Matenha seu status atualizado",
                                            true));
            }
            else
            {
                return BadRequest(new MessageReturn("Status Não Encontrado",
                                                    "Erro ao deletar status.",
                                                    false));

            }
        }
    }
}
