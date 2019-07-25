using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Learning_Session_1.Models;
namespace MVC_Learning_Session_1.Controllers
{
    public class ModalPopupDemoController : Controller
    {
        // GET: ModalPopupDemo
        //Open Modal Popup when Entire DIV in same page without using partial View.
        public ActionResult Index()
        {
            return View();
        }
        //Method open partial view from main page - to display list of products
        public ActionResult OpenProductPartialView()
        {
            Product[] products = new Product[]
             {
            new Product{Id=101,Name="Cinthol",Category="A",Rate=10},
            new Product{Id=102,Name="Dettol",Category="B", Rate=20},
            new Product{Id=103,Name="Hamam",Category="B", Rate=30},
            new Product{Id=104,Name="Pierce",Category="C", Rate=40},
            new Product{Id=105,Name="Lux",Category="A", Rate=25}

                };
            var productlist = products.ToList();
            return PartialView("OpenProductPartialView",productlist);
        }
        //Open Page that contains link to display list of product using partial View
        public ActionResult OpenMainPage()
        {
            return View();
        }
    }
}