
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WDDN1.Models;

namespace WDDN1.Controllers
{
    
    public class ViewMarkController : Controller
    {
        private Model1 db = new Model1();

        public ActionResult Index()
        {
            ViewBag.StudentId = new SelectList(db.Students, "StudentID", "Fullname");
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName");
            //RedirectToAction();
            return View();
        }
        
        [HttpPost]
        public ActionResult ViewM()
        {
            int id = int.Parse(Request["StudentId"]);

            var studentMarks = (from m in db.Marks where m.StudentId == id select m).ToList();

            return View(studentMarks);
        }
        
        
    }
}