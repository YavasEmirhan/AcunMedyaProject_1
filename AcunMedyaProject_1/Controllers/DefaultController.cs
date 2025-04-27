using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;

namespace AcunMedyaProject_1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = dB.TBL_Testimonial.ToList(); // Fetching all testimonials from the database
            return PartialView(values);
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = dB.TBL_About.ToList(); // Fetching all about information from the database
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = dB.TBL_Services.ToList(); // Fetching all services from the database
            return PartialView(values);
        }
        public PartialViewResult PartialPortfolio()
        {
            var values = dB.TBL_Project.ToList(); // Fetching all projects from the database
            return PartialView(values);
        }
        public PartialViewResult PartialContact()
        {
            var values = dB.TBL_Contact.ToList(); // Fetching all contacts from the database
            return PartialView(values);
        }
        public PartialViewResult PartialResume()
        {
            var values = dB.TBL_Education.ToList(); // Fetching all education information from the database
            return PartialView(values);
        }
        public PartialViewResult PartialJob()
        {
            var values = dB.TBL_Job.ToList(); // Fetching all projects from the database
            return PartialView(values);
        }
        public PartialViewResult PartialSkills()
        {
            var values = dB.TBL_Skills.ToList(); // Fetching all skills from the database
            return PartialView(values);
        }
        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }
        public PartialViewResult PartialMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult PartialMessage(TBL_Message message)
        {
            dB.TBL_Message.Add(message); // Adding a new message to the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index", "Default"); // Redirecting to the Index action of Default controller
        }
        public ActionResult PartialHero()
        {
            return PartialView();
        }
        public ActionResult PartialCategory()
        {
            var values = dB.TBL_Category.ToList(); // Fetching all categories from the database
            return PartialView(values);
        }

    }
}