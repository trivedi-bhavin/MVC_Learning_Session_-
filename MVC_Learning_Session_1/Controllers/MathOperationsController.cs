using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Learning_Session_1.Models;
namespace MVC_Learning_Session_1.Controllers
{
    public class MathOperationsController : Controller
    {
        // GET: MathOperations
        public ActionResult Index()
        {
            MathOperations m1 = new MathOperations();
            return View(m1);
        }
        //Can Access Button Name using Operations as an additional Argument. Not necessary to create separate property in Model as we do not have to retain this.
        [HttpPost]
        public ActionResult GetResult(MathOperations obj, int Id, string Operation)
        {
            MathOperations m = new MathOperations();
            m.Operations(obj);
             
            return View("Index", obj);
        }
        //Math operation page to call different submit method from same page using different button. Using new HTML5 Attribute name - FormAction
        //Reference learning from https://www.pluralsight.com/guides/asp-net-mvc-using-multiple-submit-buttons-with-default-model-binding-and-controller-actions
        [HttpGet]
        public ActionResult MathOp1()
        {
            MathOperations objFormActionTagDemo = new MathOperations();
            return View(objFormActionTagDemo);
        }
        [HttpPost]
        public ActionResult Addition(MathOperations obj)
        {
            obj.Result = obj.Value1 + obj.Value2;
            return View("MathOp1", obj);
        }
        [HttpPost]
        public ActionResult Subtraction(MathOperations obj)
        {
            obj.Result = obj.Value1 - obj.Value2;
            return View("MathOp1", obj);
        }
        [HttpPost]
        public ActionResult Multiplication(MathOperations obj)
        {
            obj.Result = obj.Value1 * obj.Value2;
            return View("MathOp1", obj);
        }
        [HttpPost]
        public ActionResult Divison(MathOperations obj)
        {
            obj.Result = obj.Value1 / obj.Value2;
            return View("MathOp1", obj);
        }
    }
}