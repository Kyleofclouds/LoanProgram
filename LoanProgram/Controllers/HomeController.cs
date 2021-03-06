﻿using LoanProgram.Data;
using LoanProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanProgram.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About The Developer";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How To Contact Me";

            return View();
        }
    }
}