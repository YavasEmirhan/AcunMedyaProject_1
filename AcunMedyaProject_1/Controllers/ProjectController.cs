using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models; 
namespace AcunMedyaProject_1.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            var values = dB.TBL_Project.ToList(); // Fetching all projects from the database
            return View(values);

        }
        [HttpGet]
        public ActionResult DeleteProject(int id)
        {
            var values = dB.TBL_Project.Find(id); // Finding the project by id
            dB.TBL_Project.Remove(values); // Removing the project from the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TBL_Project project)
        {
            dB.TBL_Project.Add(project); // Adding the new project to the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = dB.TBL_Project.Find(id); // Finding the project by id
            return View(values); // Returning the project to the view
        }
        [HttpPost]
        public ActionResult UpdateProject(TBL_Project model)
        {
            var values = dB.TBL_Project.Find(model.ProjectID); // Finding the project by id
            values.ProjectName = model.ProjectName; // Updating the project name
            values.Description = model.Description; // Updating the project description
            values.ProectLink = model.ProectLink; // Updating the project link
            values.Image1 = model.Image1; // Updating the first project image
            values.Image2 = model.Image2; // Updating the second project image
            values.Image3 = model.Image3; // Updating the third project image
            values.CategoryID = model.CategoryID; // Updating the project category id
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
    }
}