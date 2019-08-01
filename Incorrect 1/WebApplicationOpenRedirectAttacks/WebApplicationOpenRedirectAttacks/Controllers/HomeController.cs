using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult TestRedirect(string url)
        {
            if (string.IsNullOrEmpty(url) || Regex.IsMatch(url, @"^(\/(\w)+)+$"))
            {
                return RedirectToAction("Index", "Home");
            }
            return Redirect(url);
        }
    }
}