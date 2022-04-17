using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using TeamAnnotationAPI.Models;

namespace TeamAnnotationAPI.Controllers
{
    [Route("api")]
    public class AttachController : Controller
    {
        private IAttachService _service { get; set; }
        public AttachController(IAttachService service)
        {
            _service = service;
        }

        [HttpPost("[action]")]
        public IActionResult AddAddress([FromBody] Attach address)
        {
            try
            {

                return Ok(new MessageReturn("Objeto Retornado Com Sucesso",
                                            "",
                                            true,
                                            _service.AddAttach(address)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar Anexo",
                                                    "Erro ao adicionar anexo, por favor tente noavmente mais tarde",
                                                    false));
            }
        }

        [HttpPut("[action]")]
        public IActionResult PutAttach([FromBody] Attach attach)
        {
            try
            {
                if (_service.PutAttach(attach))
                {
                    return Ok(new MessageReturn("Sucesso ao Alterar Anexo",
                                                "Muito bom, sempre mantenha seus dados atualizados!",
                                                true));
                }
                else
                {
                    return Ok(new MessageReturn("Anexo Não Encontrado",
                                                "Erro ao alterar anexo, não foi encontrado.",
                                                false));

                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Alterar Anexo",
                                                     "Erro ao alterar anexo, por favor tente noavmente mais tarde.",
                                                     false));

            }
        }

        [HttpGet("[action]")]
        public IActionResult GetAttachments([FromQuery] int page, int size)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Anexos",
                                            "",
                                            true,
                                             _service.GetAttachments(page, size)));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Anexos",
                                                   "Erro ao consultar anexos, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpGet("[action]")]
        public IActionResult GetAttach([FromQuery] int idAttach)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Anexo",
                                            "",
                                            true,
                                            _service.GetAttach(idAttach)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Anexos",
                                                    "Erro ao consultar anexos, por favor tente noavmente mais tarde.",
                                                    false));
            }
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteAttach([FromQuery] int idAttach)
        {
            if (_service.DeleteAttach(idAttach))
            {
                return Ok(new MessageReturn("Sucesso ao Deletar Anexo",
                                            "",
                                            true));
            }
            else
            {
                return BadRequest(new MessageReturn("Anexo Não Encontrado",
                                            "Erro ao deletar anexo.",
                                            false));

            }
        }

    }
}

