using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatTree.Controllers
{
    public class GamesControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("GameDetail")]
        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult _NotFound()
        {
            return View();
                }
    }
}
