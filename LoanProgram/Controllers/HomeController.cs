using LoanProgram.Data;
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
            /*ApplicantDropdownView applicantDropdownView = new ApplicantDropdownView();
            using (var ctx = new ApplicationDbContext())
            {
                applicantDropdownView.ApplicantList = ctx.Applicants.Select(a => new SelectListItem { Text = a.FullName, Value = a.Id }).ToList();
            }*/
            return View(/*applicantDropdownView*/);
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