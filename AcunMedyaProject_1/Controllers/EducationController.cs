using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;

namespace AcunMedyaProject_1.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            var values = dB.TBL_Education.ToList(); // Fetching all education records from the database
            return View(values);
        }
        public ActionResult DeleteEducation(int id)
        {
            var values = dB.TBL_Education.Find(id); // Finding the education record by id
            dB.TBL_Education.Remove(values); // Removing the education record from the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEducation(TBL_Education education)
        {
            dB.TBL_Education.Add(education); // Adding the new education record to the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var values = dB.TBL_Education.Find(id); // Finding the education record by id
            return View(values); // Returning the education record to the view
        }
        [HttpPost]
        public ActionResult UpdateEducation(TBL_Education education)
        {
            var values = dB.TBL_Education.Find(education.EducationID); // Finding the education record by id
            values.StartYear = education.StartYear; // Updating the start year
            values.EndYear =education.EndYear; // Updating the end year
            values.Name = education.Name; // Updating the name
            values.Description = education.Description; // Updating the description
            values.Section = education.Section; // Updating the section
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }


        }
}