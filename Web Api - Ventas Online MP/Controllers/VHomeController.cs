﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Api___Ventas_Online_MP.Controllers
{
    public class VHomeController : Controller
    {
        // GET: VHome
        public ActionResult Inicio()
        {
            return View();
        }
    }
}