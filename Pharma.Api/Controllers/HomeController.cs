﻿using System.Web.Mvc;
using AttributeRouting.Web.Mvc;

namespace Pharma.Api.Controllers
{
    public class HomeController : Controller
    {
        [GET("/")]
        public ActionResult Index()
        {
            return View();
        }

        [GET("/prueba")]
        public ActionResult Prueba()
        {
            return View();
        }
    }
}
