using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // Display Home page
        public ActionResult Index()
        {
            return View();
        }

        // Display About page
        public ActionResult About()
        {
            return View();
        }

        // Display Contact page
        public ActionResult Contact()
        {
            return View();
        }

    }
}