using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Auth.Contracts;
using Domain.Domains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.DTO;
using Service.Contracts;
using TeamAnnotationAPI.Models;

namespace TeamAnnotationAPI.Controllers
{
    [Route("api")]
    public class AnnotationController : Controller
    {
        private IAnnotationService _service { get; set; }
        private ITokenService _token { get; set; }

        public AnnotationController(IAnnotationService service, ITokenService token)
        {
            _service = service;
            _token = token;
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetAnnotations([FromQuery] int page, int size, int idProject)
        {

            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar",
                                            "",
                                            true,
                                            await _service.GetAnnotations(page, size, idProject)));

            }
            catch (Exception e)
            {
                return BadRequest(new MessageReturn("Erro ao Consultar",
                                                   "Erro ao consultar, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }

        [HttpGet("[action]")]
        [Authorize]
        public async Task<IActionResult> GetAnnotation([FromQuery] int idAnnotation)
        {

            try
            {

                return Ok(new MessageReturn("Sucesso ao Consultar",
                                            "",
                                            true,
                                            await _service.GetAnnotation(idAnnotation)));

            }
            catch(Exception e)
            {
                return BadRequest(new MessageReturn("Erro",
                                                   "Erro, por favor tente noavmente mais tarde.",
                                                   false));

            }
        }


        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> AddAnnotation([FromBody] AnnotationDTO notatition)
        {
            var identity = User.Identity as ClaimsIdentity;
            notatition.idUser = Convert.ToInt32(identity.Claims.ToList()[1].Value);

            notatition.idUser = 1;
            try
            {

                return Ok(new MessageReturn("Sucesso ao Adicionar",
                                            "",
                                            true,
                                            await _service.AddAnnotation(notatition)));

            }
            catch (Exception e)
            {
                return BadRequest(new MessageReturn("Erro",
                                                   e.InnerException.ToString(),
                                                   false));

            }
        }


        [HttpPut("[action]")]
        [Authorize]
        public async Task<IActionResult> PutAnnotation([FromBody] AnnotationDTO notatition)
        {
            try
            {
                if (await _service.PutAnnotation(notatition))
                {
                    return Ok(new MessageReturn("Sucesso ao Alterar",
                                                "Muito bom, sempre mantenha seus dados atualizados!",
                                                true));
                }
                else
                {
                    return Ok(new MessageReturn("Não Encontrado",
                                                "Erro ao alterar, não foi encontrado.",
                                                false));

                }
            }
            catch (Exception e)
            {
                return BadRequest(new MessageReturn("Erro ao Alterar",
                                                     "Erro ao alterar, por favor tente novamente mais tarde.",
                                                     false));

            }
        }

        [HttpDelete("[action]")]
        [Authorize]
        public async Task<IActionResult> DeleteAnnotation([FromQuery] int idAnnotation)
        {
            try
            {
                if (await _service.DeleteAnnotation(idAnnotation))
                {
                    return Ok(new MessageReturn("Sucesso ao Deletar",
                                                "",
                                                true));
                }
                else
                {
                    return Ok(new MessageReturn("Não Encontrado",
                                                "Erro ao deletar, não foi encontrado.",
                                                false));

                }
            }
            catch
            {
                return BadRequest(new MessageReturn("Erro ao Deletar",
                                                     "Erro ao deletar, por favor tente novamente mais tarde.",
                                                     false));

            }
        }


    }
}
