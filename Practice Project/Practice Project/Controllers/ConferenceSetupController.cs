using Microsoft.AspNetCore.Mvc;
using Practice_Project.Data;
using Practice_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Project.Controllers
{
    public class ConferenceSetupController : Controller
    {
        private readonly PracticeProjectDBContext _practiceProjectDBContext;

        public ConferenceSetupController(PracticeProjectDBContext practiceProjectDBContext)
        {
            _practiceProjectDBContext = practiceProjectDBContext;
        }
        public IActionResult Index()
        {
            List<ConferenceSetupTable> conferenceSetupTables = _practiceProjectDBContext.ConferenceSetupTables.ToList();
            return View(conferenceSetupTables);
        }
    }
}
