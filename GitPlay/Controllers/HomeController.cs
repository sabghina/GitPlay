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
        public string Index()
        {
            return "Let's master github ";
        }
        public string Index2()
        {
            return "First Branch Created";
        }
    }
}