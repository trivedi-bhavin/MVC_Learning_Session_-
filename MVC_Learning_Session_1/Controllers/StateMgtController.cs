using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Learning_Session_1.Controllers
{
    public class StateMgtController : Controller
    {
        // GET: StateMgt
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewBagDemo(string Name1)
        {
            if(Name1 == null)
            { 
                ViewBag.Name1 = Name1;
            }
            else
            {
                if (Name1=="")
                { 
                    if(ViewBag.Name1 == null) { 
                         ViewBag.Name1 = "ViewBag.Name1 is null";
                    }
                }
                else
                {
                    ViewBag.Name1 = Name1;
                }
            }
            return View();
        }
        //To learn about TempData - 

        public ActionResult TempDataDemo(string Name1)
        {
           
                if (Name1 != null)
                {
                TempData["Name1"] = Name1;
            }
           
            
            TempData.Keep();
            return View();
            
        }
        public ActionResult StateMgtDemoWrite(string Name1, string Name2)
        {
            Session["Name1"] = Name1;
            Session["Name2"] = Name2;

            return View();
        }
        public ActionResult StateMgtDemoRead()
        {
            return View();
        }
    }
}