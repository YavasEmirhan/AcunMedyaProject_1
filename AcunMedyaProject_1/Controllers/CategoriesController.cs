using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;
namespace AcunMedyaProject_1.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories MVC WİEW CONTROLLER 
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            //String Byte int liste
            var values = dB.TBL_Category.ToList(); // Fetching all categories from the database
            return View(values);
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = dB.TBL_Category.Find(id); // Finding the category by id 
            dB.TBL_Category.Remove(values); // Removing the category from the database  
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(TBL_Category category)
        {
            dB.TBL_Category.Add(category); // Adding the new category to the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = dB.TBL_Category.Find(id); // Finding the category by id
            return View(values); // Returning the category to the view
        }
        [HttpPost]
        public ActionResult UpdateCategory(TBL_Category model)
        {
            var values = dB.TBL_Category.Find(model.CategoryID); // Finding the category by id
            values.CategoryName = model.CategoryName; // Updating the category name
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action    
        }

        }
}