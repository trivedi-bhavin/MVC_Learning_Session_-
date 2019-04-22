using MVC_Learning_Session_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        
    }
}