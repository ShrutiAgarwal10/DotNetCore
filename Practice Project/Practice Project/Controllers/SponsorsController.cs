using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice_Project.Data;
using Practice_Project.Models;

namespace Practice_Project.Controllers
{
    public class SponsorsController : Controller
    {
        private readonly PracticeProjectDBContext _practiceProjectDBContext;

        public SponsorsController(PracticeProjectDBContext practiceProjectDBContext)
        {
            _practiceProjectDBContext = practiceProjectDBContext;
        }
        public IActionResult Index()
        {
            List<SponsorsTable> sponsorTables = _practiceProjectDBContext.SponsorsTables.ToList();
            return View(sponsorTables);
        }
    }
}
