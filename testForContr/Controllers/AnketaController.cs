using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testForContr.Controllers
{
    public class AnketaController : Controller
    {
        public IActionResult Anketa()
        {
            return View();
        }
    }
}
