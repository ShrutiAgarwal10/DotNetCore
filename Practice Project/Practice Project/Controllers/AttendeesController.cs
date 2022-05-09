using Microsoft.AspNetCore.Mvc;
using Practice_Project.Data;
using Practice_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Project.Controllers
{
    public class AttendeesController : Controller
    {
        private readonly PracticeProjectDBContext _practiceProjectDBContext;

        public AttendeesController(PracticeProjectDBContext practiceProjectDBContext)
        {
            _practiceProjectDBContext = practiceProjectDBContext;
        }
        public IActionResult Index()
        {
            List<AttendeesTable> attendeesTables = _practiceProjectDBContext.AttendeesTables.ToList();
            return View(attendeesTables);
        }

        public IActionResult Create()
        {
            AttendeesTable attendeesTable = new AttendeesTable();
            return View(attendeesTable);
        }
        [HttpPost]
        public IActionResult Create(AttendeesTable attendeesTable)
        {
            _practiceProjectDBContext.Attach(attendeesTable);
            _practiceProjectDBContext.Entry(attendeesTable).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _practiceProjectDBContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            AttendeesTable attendeesTable = _practiceProjectDBContext.AttendeesTables.Where(p => p.AmsId == id).FirstOrDefault();
            return View(attendeesTable);
        }
        [HttpPost]
        public IActionResult Edit(AttendeesTable attendeesTable)
        {
            _practiceProjectDBContext.Attach(attendeesTable);
            _practiceProjectDBContext.Entry(attendeesTable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _practiceProjectDBContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int Id)
        {
            AttendeesTable attendeesTable = _practiceProjectDBContext.AttendeesTables.Where(p => p.AmsId == Id).FirstOrDefault();
           
            return View(attendeesTable);
        }
        public IActionResult Delete(int id)
        {
           AttendeesTable attendeesTable = _practiceProjectDBContext.AttendeesTables.Where(p => p.AmsId == id).FirstOrDefault();
            return View(attendeesTable);
        }
        [HttpPost]
        public IActionResult Delete(AttendeesTable attendeesTable)
        {
            
            _practiceProjectDBContext.Attach(attendeesTable);
            _practiceProjectDBContext.Entry(attendeesTable).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _practiceProjectDBContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
