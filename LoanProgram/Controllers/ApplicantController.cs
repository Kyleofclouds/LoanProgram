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
    public class ApplicantController : Controller
    {
        // GET: Applicant
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ApplicantService(userId);
            var model = service.GetApplicants();

            return View(model);
        }
        // CREATE: Applicant
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ApplicantCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateApplicantService();

            if (service.CreateApplicant(model))
            {
                TempData["SaveResult"] = "Applicant successfully created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Applicant could not be created.");
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var svc = CreateApplicantService();
            var model = svc.GetApplicantById(id);

            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var service = CreateApplicantService();
            var detail = service.GetApplicantById(id);
            var model =
                new ApplicantEdit
                {
                    FirstName = detail.FirstName,
                    LastName = detail.LastName,
                    Age = detail.Age,
                    Address = detail.Address,
                    MarriageStatus = detail.MarriageStatus,
                    IsHeadOfHousehold = detail.IsHeadOfHousehold,
                    SizeOfHousehold = detail.SizeOfHousehold
                };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ApplicantEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.Id != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateApplicantService();

            if (service.UpdateApplicant(model))
            {
                TempData["SaveResult"] = "Applicant Data Successfully Updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Failed to Update Applicant");
            return View(model);
        }
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateApplicantService();
            var model = svc.GetApplicantById(id);

            return View(model);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateApplicantService();

            service.DeleteApplicant(id);

            TempData["SaveResult"] = "Client Was Deleted From Roster";

            return RedirectToAction("Index");
        }
        private ApplicantService CreateApplicantService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ApplicantService(userId);
            return service;
        }
    }
}