using LoanProgram.Models;
using LoanProgram.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanProgram.Controllers
{
    [Authorize]
    public class ApplicationController : Controller
    {
        // GET: Application
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ApplicationService(userId);
            var model = service.GetApplications();

            return View(model);
        }
        //CREATE: Application
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ApplicationCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateApplicationService();

            if (service.CreateApplication(model))
            {
                TempData["SaveResult"] = "Application successfully created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Application could not be created.");
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var svc = CreateApplicationService();
            var model = svc.GetApplicationById(id);

            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var service = CreateApplicationService();
            var detail = service.GetApplicationById(id);
            var model =
                new ApplicationEdit
                {
                    ApplicantId = detail.ApplicantId,
                    Type = detail.Type,
                    Description = detail.Description,
                    Occupation = detail.Occupation,
                    Salary = detail.Salary,
                    MoveInDate = detail.MoveInDate,
                    Phone = detail.Phone,
                    Email = detail.Email,
                    Contact = detail.Contact,
                    PreferredConsultant = detail.PreferredConsultant
                };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ApplicationEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.Id != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateApplicationService();

            if (service.UpdateApplication(model))
            {
                TempData["SaveResult"] = "Application Successfully Updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Failed to Update Application");
            return View(model);
        }
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateApplicationService();
            var model = svc.GetApplicationById(id);

            return View(model);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteApplication(int id)
        {
            var service = CreateApplicationService();

            service.DeleteApplication(id);

            TempData["SaveResult"] = "Your note was deleted";

            return RedirectToAction("Index");
        }
        private ApplicationService CreateApplicationService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ApplicationService(userId);
            return service;
        }
    }
}