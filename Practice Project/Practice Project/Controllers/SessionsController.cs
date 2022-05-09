using Microsoft.AspNetCore.Mvc;
using Practice_Project.Data;
using Practice_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Project.Controllers
{
    public class SessionsController : Controller
    {
        private readonly PracticeProjectDBContext _practiceProjectDBContext;

        public SessionsController(PracticeProjectDBContext practiceProjectDBContext)
        {
            _practiceProjectDBContext = practiceProjectDBContext;
        }
        public IActionResult Index()
        {
            List<SessionsTable> sessionsTables = _practiceProjectDBContext.SessionsTables.ToList();
            return View(sessionsTables);
        }
    }
}
