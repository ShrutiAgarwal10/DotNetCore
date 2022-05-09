using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice_Project.Data;
using Practice_Project.Models;

namespace Practice_Project.Controllers
{
    public class UsersController : Controller
    {
        private readonly PracticeProjectDBContext _practiceProjectDBContext;

        public UsersController(PracticeProjectDBContext practiceProjectDBContext)
        {
            _practiceProjectDBContext = practiceProjectDBContext;
        }
        public IActionResult Index()
        {
            List<UsersTable> usersTables = _practiceProjectDBContext.UsersTables.ToList();
            return View(usersTables);
        }
    }
}
