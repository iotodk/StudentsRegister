using StudentsRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsRegister.Controllers
{
    public class StudentsController : Controller
    {
        private StudentsContext db = new StudentsContext();
        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        public ActionResult Edit(int id)
        {
            var student = db.Students.Find(id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}