﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebLiveChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult chat()
        {
            return View();
        }
    }
}