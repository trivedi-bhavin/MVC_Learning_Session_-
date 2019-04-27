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
        //Post Method Example which retrive information from View and send JSON as a result
        [HttpPost]
        public JsonResult GetItemListJson(MVC_Learning_Session_1.Models.Item item)
        {
            // var req = Request.Form.ToString();

            var itemList = MVC_Learning_Session_1.Models.DBMethods.GetItemList();
            return Json(itemList);
        }
        // Get:GetItemListJSON
        //Access JSON Data Using HTTP Get Method
        public ActionResult GetItemListJSON()
        {
            var itemList = MVC_Learning_Session_1.Models.DBMethods.GetItemList();
            return Json(itemList, JsonRequestBehavior.AllowGet);
        }
    }
}