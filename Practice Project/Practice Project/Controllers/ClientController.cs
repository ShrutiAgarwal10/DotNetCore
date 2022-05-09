using Microsoft.AspNetCore.Mvc;
using Practice_Project.Data;
using Practice_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Project.Controllers
{
    public class ClientController : Controller
    {
        private readonly PracticeProjectDBContext _practiceProjectDBContext;

        public ClientController(PracticeProjectDBContext practiceProjectDBContext)
        {
            _practiceProjectDBContext = practiceProjectDBContext;
        }
        public IActionResult Index()
        {
            List<ClientTable> clientTables = _practiceProjectDBContext.ClientTables.ToList();
            return View(clientTables);
        }
    }
}
