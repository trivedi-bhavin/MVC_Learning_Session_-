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
        //Open Page to create/store details into Cookie
        public ActionResult CreateCookie(string Name1, string Degree, string Grade)
        {
            if (Name1 != null)
            {
                HttpCookie objCookie = new HttpCookie("Info");
                objCookie.Values["Name1"] = Name1;
                objCookie.Values["Degree"] = Degree;
                objCookie.Values["Grade"] = Grade;
                objCookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(objCookie);

            }
            return View();
        }
        //Open Page to read details from Cookie
        public ActionResult ReadCookie()
        {
            HttpCookie obj = Request.Cookies["Info"];
            if (obj == null)
            {
                ViewBag.Name1 = "Cookie Not Exists ...";
                ViewBag.Degree = "Cookie Not Exists ...";
                ViewBag.Grade = "Cookie Not Exists ...";

            }
            else
            {
                ViewBag.Name1 = obj["Name1"];
                ViewBag.Degree = obj["Degree"];
                ViewBag.Grade = obj["Grade"];

            }
            return View();
        }
    }
}