using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Learning.Business;
using Learning.WebSite.Models;


namespace Learning.WebSite.Controllers
{
    public class HomeController : Controller
    {

        private readonly IClassManager classManager;
        public HomeController(IClassManager classManager)
        {
            this.classManager = classManager;
        }


        public ActionResult Index()
        {
            var classes = classManager.Classes
                                            .Select(t => new Learning.WebSite.Models.ClassModel(t.ClassId, t.ClassName, t.ClassDescription, t.ClassPrice))
                                            .ToArray();
            var model = new IndexModel { Classes = classes };
            return View(model);
        }

    


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}