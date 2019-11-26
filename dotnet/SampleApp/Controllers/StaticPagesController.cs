using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleApp.Controllers
{
    public class StaticPagesController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        
        public IActionResult Help()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }
    }
}