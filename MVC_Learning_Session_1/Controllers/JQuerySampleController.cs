using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Learning_Session_1.Controllers
{
    public class JQuerySampleController : Controller
    {
        // GET: JQuerySample
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetJson()
        {
           
            MVC_Learning_Session_1.Models.Item item = new Models.Item() { ID = 101, Name = "Cinthol", Category = "A", Rate = 60 };
            return Json(item);
        }
        public JsonResult GetItemListJson()
        {
            var itemList = MVC_Learning_Session_1.Models.DBMethods.GetItemList();
            return Json(itemList);
        }
    }
}