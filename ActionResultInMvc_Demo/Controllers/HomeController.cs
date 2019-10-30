using ActionResultInMvc_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultInMvc_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly CutomerContext db = new CutomerContext();

        public ActionResult Index()
        {
            var customer = db.Customers.ToList();
            return View(customer);
        }

        public ViewResult MyView()
        {
            var products = db.Products.ToList();
            return View(products);
        }

        public ContentResult Content()
        {
            return Content("<h3>This is contetn result.</h3>");
        }

        public EmptyResult Empty()
        {
            return new EmptyResult();
        }

        public JsonResult GetCustomers()
        {
            var cutomers = db.Customers.ToList();
            return Json(new { data=cutomers},JsonRequestBehavior.AllowGet);
        }

        public JavaScriptResult MyScript()
        {
            var message = "alert('Hello World! Welcome to ASP.Net MVC.');";
            return JavaScript(message);
        }

        public PartialViewResult Products()
        {
            return PartialView("_Products");
        }

        public FileResult MyFile()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Uploads/NET Interview Questions and Answers.pdf"));
            return File(fileBytes,".pdf");

            //return File(Url.Content("~/Uploads/NET Interview Questions and Answers.pdf"),".pdf");
        }

        public RedirectResult GitProfile()
        {
            return Redirect("https://github.com/farhan1386");
        }

        public ActionResult Customers()
        {
            return RedirectToAction("Index","Home");
        }

        public RedirectToRouteResult ProductsList()
        {
            return RedirectToRoute(new { controller="Products",action="Index"});
        }
    }
}