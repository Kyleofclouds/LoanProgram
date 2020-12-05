using LoanProgram.Data;
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
    public class ConsultantController : Controller
    {
        // GET: Consultant
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ConsultantService(userId);
            var model = service.GetConsultants();

            return View(model);
        }
        //CREATE: Consultant
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ConsultantCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var service = CreateConsultantService();

            if (service.CreateConsultant(model))
            {
                TempData["SaveResult"] = "Consultant successfully created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Consultant could not be created.");
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var svc = CreateConsultantService();
            var model = svc.GetConsultantById(id);

            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var service = CreateConsultantService();
            var detail = service.GetConsultantById(id);
            var model =
                new ConsultantEdit
                {
                    FirstName = detail.FirstName,
                    LastName = detail.LastName,
                    Specialization = detail.Specialization,
                    IsCurrentEmployee = detail.IsCurrentEmployee
                };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ConsultantEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.Id != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateConsultantService();

            if (service.UpdateConsultant(model))
            {
                TempData["SaveResult"] = "Consultant Details Successfully Updated";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Failed to Update Consultant");
            return View(model);
        }
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateConsultantService();
            var model = svc.GetConsultantById(id);

            return View(model);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateConsultantService();

            service.DeleteConsultant(id);

            TempData["SaveResult"] = "Your note was deleted";

            return RedirectToAction("Index");
        }
        private ConsultantService CreateConsultantService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ConsultantService(userId);
            return service;
        }
    }
}