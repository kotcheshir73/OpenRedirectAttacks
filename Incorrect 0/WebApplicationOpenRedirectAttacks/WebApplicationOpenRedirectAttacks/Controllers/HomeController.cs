using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationOpenRedirectAttacks.Models;

namespace WebApplicationOpenRedirectAttacks.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        /// <summary>
        /// View for call redirection
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult TestRedirect(string url)
        {
            if(string.IsNullOrEmpty(url))
            {
                return RedirectToAction("Index", "Home");
            }

            return View(new TestRedirect { Url = url });
        }
    }
}