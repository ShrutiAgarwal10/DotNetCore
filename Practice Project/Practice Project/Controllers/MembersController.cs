using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice_Project.Data;
using Practice_Project.Models;

namespace Practice_Project.Controllers
{
    public class MembersController : Controller
    {
        private readonly PracticeProjectDBContext _practiceProjectDBContext;

        public MembersController(PracticeProjectDBContext practiceProjectDBContext)
        {
            _practiceProjectDBContext = practiceProjectDBContext;
        }
        public IActionResult Index()
        {
            List<MembersTable> membersTables = _practiceProjectDBContext.MembersTables.ToList();
            return View(membersTables);
        }
    }
}
