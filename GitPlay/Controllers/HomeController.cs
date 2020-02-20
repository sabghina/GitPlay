﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitPlay.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return View("Error");
            else
                return View("index");
        }
    }
}