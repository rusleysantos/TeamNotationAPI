using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamAnnotationAPI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return Ok("Bem-Vindo a Team Annotation Api");
        }
    }
}
