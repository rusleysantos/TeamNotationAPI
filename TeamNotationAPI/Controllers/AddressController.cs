using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Domain.Domains;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using TeamNotationAPI.Models;

namespace TeamNotationAPI.Controllers
{
    [Route("api")]
    public class AddressController : Controller
    {
        private IAddressService _service { get; set; }
        public AddressController(IAddressService service)
        {
            _service = service;
        }

        [HttpPost("[action]")]
        public IActionResult AddAddress([FromBody] Address address)
        {
            try
            {

                return Ok(new MessageReturn("Objeto Retornado Com Sucesso",
                                            "",
                                            true,
                                            _service.AddAddress(address)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Adicionar Endereço",
                                                    "Erro ao adicionar endereço, por favor tente noavmente mais tarde",
                                                    false));
            }
        }

        [HttpPut("[action]")]
        public IActionResult PutAddress([FromBody] Address address)
        {
            try
            {
                if (_service.PutAddress(address))
                {
                    return Ok(new MessageReturn("Sucesso ao Alterar Endereço",
                                                "Muito bom, sempre mantenha seus dados atualizados!",
                                                true));
                }
                else
                {
                    return Ok(new MessageReturn("Endeço Não Encontrado",
                                                "Erro ao alterar endereço, não foi encontrado.",
                                                false));

                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Alterar Endereço",
                                                     "Erro ao alterar endereço, por favor tente noavmente mais tarde.",
                                                     false));

            }
        }

        [HttpGet("[action]")]
        public IActionResult GetAdresses([FromQuery] int page, int size)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Endereços",
                                            "",
                                            true,
                                             _service.GetAdresses(page, size)));

            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Endereços",
                                                   "Erro ao consultar endereços, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpGet("[action]")]
        public IActionResult GetAddress([FromQuery] int idAdress)
        {
            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar Endereço",
                                            "",
                                            true,
                                            _service.GetAddress(idAdress)));
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Consultar Endereços",
                                                    "Erro ao consultar endereços, por favor tente noavmente mais tarde.",
                                                    false));
            }
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteAddress([FromQuery] int idAdress)
        {
            if (_service.DeleteAddress(idAdress))
            {
                return Ok(new MessageReturn("Sucesso ao Deletar Endereço",
                                            "Matenha seu endereço atualizado",
                                            true));
            }
            else
            {
                return BadRequest(new MessageReturn("Endeço Não Encontrado",
                                            "Erro ao deletar endereço.",
                                            false));

            }
        }

    }
}
