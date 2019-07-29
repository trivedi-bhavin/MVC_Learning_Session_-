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
            List<VM_Subjects_Group> obj = VM_Subjects_Group.GetVM_Subjects_Group();
          
            return View(obj);
        }
    }
}