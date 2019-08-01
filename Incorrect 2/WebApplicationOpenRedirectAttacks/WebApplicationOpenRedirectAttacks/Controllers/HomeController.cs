﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            var base64EncodedBytes = Convert.FromBase64String(url);
            return Redirect(System.Text.Encoding.UTF8.GetString(base64EncodedBytes));
        }
    }
}