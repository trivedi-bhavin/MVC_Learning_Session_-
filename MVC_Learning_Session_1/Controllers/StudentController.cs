using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using MVC_Learning_Session_1.Models;
namespace MVC_Learning_Session_1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student obj = Student.GetStudent();
            return View(obj);
        }

        //Reference Article - Learning -https://www.pluralsight.com/guides/asp.net-mvc-getting-default-data-binding-right-for-hierarchical-views
        [HttpPost]
        public ActionResult SubmitData(Student obj)
         {
            Student item = obj;
           
            string id = Request["Id"];
            return Content("Success");
        }
        [HttpPost]
        public ActionResult SubmitJSONData(string json)
        {
            Student obj = new JavaScriptSerializer().Deserialize<Student>(json);

            //string id = obj.Id.ToString();
            string id = Request["Id"];
            return Content("Success");
        }

        public JsonResult GetStudentJSON()
        {
            Student obj = Student.GetStudent();
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }

}