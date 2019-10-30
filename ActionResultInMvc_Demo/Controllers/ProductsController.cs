using ActionResultInMvc_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultInMvc_Demo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly CutomerContext db = new CutomerContext();

        public ActionResult Index()
        {
            var produtcs = db.Products.ToList();
            return View(produtcs);
        }
    }
}