using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Learning_Session_1.Controllers
{
    public class RazorSampleController : Controller
    {
        // GET: RazorSample
        public ActionResult Index()
        {
            return View();
        }
    }
}