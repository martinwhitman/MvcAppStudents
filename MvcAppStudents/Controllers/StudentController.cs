using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcAppStudents.Orchestrators;

namespace MvcAppStudents.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var model = new StudentOrchestrator().GetStudentData();
            return View(model);
        }
    }
}