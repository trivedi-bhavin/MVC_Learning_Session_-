using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Learning_Session_1.Models;
namespace MVC_Learning_Session_1.Controllers
{
    public class StudentSubjectController : Controller
    {
        // GET: StudentSubject
        public ActionResult Index()
        {
            //To get details using Form Object and Submit C# Model Binding
            List<VM_Subjects_Group> obj = VM_Subjects_Group.GetVM_Subjects_Group();
            ViewBag.EnrollmentNo = obj[0].ErollmentNo+1;
            return View(obj);
        }


        [HttpPost]
        public ActionResult Submit(List<VM_Subjects_Group> list, string EnrollmentNo)
        {
            //To get details using Form Object and Submit C# Model Binding
            List<VM_Subjects_Group> obj = list;
            return RedirectToAction("Index");
        }
        public JsonResult GetJsonResult()
        {
            List<VM_Subjects_Group> obj = VM_Subjects_Group.GetVM_Subjects_Group();
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index2()
        {
            //To get details using AJAX Request 
            List<VM_Subjects_Group> obj = VM_Subjects_Group.GetVM_Subjects_Group();
            ViewBag.EnrollmentNo = obj[0].ErollmentNo + 1;
            return View(obj);
        }
        [HttpPost]
        public ActionResult Submit2(List<VM_Subjects_Group> list, string EnrollmentNo)
        {
            //To submit list of records from UI into list argument using AJAX POST
            List<VM_Subjects_Group> obj = list;
            return RedirectToAction("Index");
        }
    }
}