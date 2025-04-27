using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;
namespace AcunMedyaProject_1.Controllers
{
    public class JobController : Controller
    {
        // GET: Jobs
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            var values = dB.TBL_Job.ToList(); // Fetching all categories from the database
            return View(values);
        }
        public ActionResult DeleteJob(int id)
        {
            var values = dB.TBL_Job.Find(id); // Finding the category by id
            dB.TBL_Job.Remove(values); // Removing the category from the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult CreateJob()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateJob(TBL_Job job)
        {
            dB.TBL_Job.Add(job); // Adding the new category to the database
            dB.SaveChanges(); // Saving changes to the database    
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult UpdateJob(int id)
        {
            var values = dB.TBL_Job.Find(id); // Finding the category by id
            return View(values); // Returning the category to the view
        }
        [HttpPost]
        public ActionResult UpdateJob(TBL_Job job)
        {
            var values = dB.TBL_Job.Find(job.JobID); // Finding the category by id
            values.Title = job.Title; // Updating the title
            values.StartDate = job.StartDate; // Updating the start date
            values.EndDate = job.EndDate; // Updating the end date
            values.CompanyName = job.CompanyName; // Updating the company name
            values.Description = job.Description; // Updating the description
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }


        }
}