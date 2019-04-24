using MVC_Learning_Session_1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace MVC_Learning_Session_1.Controllers
{
    public class ProductController : Controller
    {
        /*Initialize In Memory Product Array*/
        Product[] products = new Product[]
        {
            new Product{Id=101,Name="Cinthol",Category="A",Rate=10},
            new Product{Id=102,Name="Dettol",Category="B", Rate=20}
        };
        // GET: Product
        public ActionResult Index()
        {
            var productlist = products.ToList();
            return View(productlist);
        }
        //Get: Product List - Display View Without Scafolding
        public ActionResult List()
        {
            return View(products.ToList());
        }
        //Get: Product Detail Page - To display details of single product
        public ActionResult DisplayProduct(int id)
        {
            var product = products.ToList().Where(p => p.Id == id).FirstOrDefault();
            if (product == null)
                return HttpNotFound();
            
              return View(product);
        }
        //Get: Product Edit
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            var product = products.ToList().Where(p => p.Id == id).FirstOrDefault();
            if (product==null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        //Post: Product Save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include ="Id,Name,Category,Rate")] Product product)
        {
            if(ModelState.IsValid)
            {
                /*Need to add logic to udpdate into database*/
                return RedirectToAction("List");
            }
            return View(product);
        }
        public ActionResult JSONData()
        {
            var jsondata = JsonConvert.SerializeObject(products.ToList());
            return Json(jsondata, JsonRequestBehavior.AllowGet);
            //return Json(new {Id=101,Name="Dettol"}, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Content()
        {
            //return Content("We will do it ...");
            return Content(HttpUtility.HtmlEncode("We will do it"));
        }
    }
}