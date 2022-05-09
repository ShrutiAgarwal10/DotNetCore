using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Project.Controllers
{
    public class BadgesController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
