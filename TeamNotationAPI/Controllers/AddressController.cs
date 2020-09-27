using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamNotationAPI.Controllers
{
    [Route("api")]
    public class AddressController : Controller
    {
        [HttpPost("[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
