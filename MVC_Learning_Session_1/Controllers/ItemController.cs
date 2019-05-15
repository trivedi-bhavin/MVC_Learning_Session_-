using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Learning_Session_1.Models;
using Newtonsoft.Json;

namespace MVC_Learning_Session_1.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item List Display
        public ActionResult Index()
        {
            var itemList = DBMethods.GetItemList();
            return View(itemList);
        }
        public ActionResult ItemList()
        {
            var itemList = DBMethods.GetItemList();
            return View();
        }
        //Get: Open Page to insert new Item
        public ActionResult Create()
        {
           // Item obj = new Item();
            return View();
        }
        //Post: To insert new Item
        [HttpPost]
        public ActionResult Create(Item obj, FormCollection fc)
        {
            int affected = DBMethods.InsertItem(obj);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id)
        {
            Item obj = DBMethods.GetItem(Id);
            return View(obj);
        }
        [HttpPost]
        public ActionResult Edit(Item obj)
        {
            int affected = 0;
            affected = DBMethods.EditItem(obj);
            return RedirectToAction("Index");
        }
        //[HttpPost]
        public ActionResult Delete(int Id)
        {
            int affected = 0;
            affected = DBMethods.DeleteItem(Id);

            return RedirectToAction("Index");

        }
        public ActionResult ItemLOVDemo()
        {

           var itemList = DBMethods.GetItemList();
           SelectList Items = new SelectList(itemList, "Id", "Name");
           ViewBag.ItemList = Items;
           return View();
        }
        //Get Item List in JSON Format
        public ActionResult ItemJSONData()
        {
            var itemList = DBMethods.GetItemList();

            var jsondata = JsonConvert.SerializeObject(itemList);
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }
    }
   
}