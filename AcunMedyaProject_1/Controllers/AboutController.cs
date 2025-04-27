using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;
namespace AcunMedyaProject_1.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            var value = dB.TBL_About.ToList(); // Fetching all about information from the database
            return View(value);
        }
        public ActionResult DeleteAbout(int id)
        {
            var value = dB.TBL_About.Find(id); // Finding the about information by ID
            dB.TBL_About.Remove(value); // Removing the about information from the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View(); // Returning the view for adding new about information
        }
        [HttpPost]
        public ActionResult CreateAbout(TBL_About about)
        {
            dB.TBL_About.Add(about); // Adding the new about information to the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = dB.TBL_About.Find(id); // Finding the about information by ID
            return View(value); // Returning the view for updating the about information
        }
        [HttpPost]
        public ActionResult UpdateAbout(TBL_About about)
        {
            var value = dB.TBL_About.Find(about.AboutID); // Finding the about information by ID
            value.ImageUrl = about.ImageUrl; // Updating the about information properties
            value.Title = about.Title;
            value.BirthDay = about.BirthDay;
            value.Website = about.Website;
            value.Phone = about.Phone;
            value.City = about.City;
            value.Age = about.Age;
            value.Email = about.Email;
            value.Freelance = about.Freelance;
            value.Description1 = about.Description1;
            value.Description2 = about.Description2;
            value.Degree = about.Degree;
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
    }
}