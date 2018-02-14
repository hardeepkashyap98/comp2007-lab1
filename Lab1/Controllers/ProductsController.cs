﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Details?device=[value]
        public ActionResult Details(string device)
        {
            ViewBag.Device = device;
            return View();
        }

    }
}