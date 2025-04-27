using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;

namespace AcunMedyaProject_1.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            var values = dB.TBL_Skills.ToList(); // Fetching all skills from the database
            return View(values);
        }
        [HttpGet]
        public ActionResult DeleteSkills(int id)
        {
            var values = dB.TBL_Skills.Find(id); // Finding the skill by id
            dB.TBL_Skills.Remove(values); // Removing the skill from the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult CreateSkills()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkills(TBL_Skills Skills)
        {
           dB.TBL_Skills.Add(Skills); // Adding the new skill to the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult UpdateSkills(int id)
        {
            var values = dB.TBL_Skills.Find(id); // Finding the skill by id
            return View(values); // Returning the skill to the view
        }
        [HttpPost]
        public ActionResult UpdateSkills(TBL_Skills model)
        {
            var values = dB.TBL_Skills.Find(model.SkilssID); // Finding the skill by id
            values.SkillName = model.SkillName; // Updating the skill name
            values.Percentage = model.Percentage; // Updating the skill percentage
            values.Description = model.Description; // Updating the skill description
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }

        }
}