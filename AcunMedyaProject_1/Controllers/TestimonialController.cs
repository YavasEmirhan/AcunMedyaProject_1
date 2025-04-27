using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;
namespace AcunMedyaProject_1.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonials
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            var values = dB.TBL_Testimonial.ToList(); // Fetching all testimonials from the database
            return View(values);
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = dB.TBL_Testimonial.Find(id); // Finding the testimonial by ID
            dB.TBL_Testimonial.Remove(values); // Removing the testimonial from the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View(); // Returning the view for adding a new testimonial
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TBL_Testimonial testimonial)
        {
            dB.TBL_Testimonial.Add(testimonial); // Adding the new testimonial to the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = dB.TBL_Testimonial.Find(id); // Finding the testimonial by ID
            return View(values); // Returning the view for updating the testimonial
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(TBL_Testimonial testimonial)
        {
            var values = dB.TBL_Testimonial.Find(testimonial.TestimonialID); // Finding the testimonial by ID
            values.Description1 = testimonial.Description1; // Updating the testimonial properties
            values.TestimonialName = testimonial.TestimonialName;
            values.Description2 = testimonial.Description2;
            values.ImageUrl = testimonial.ImageUrl;
            values.Title = testimonial.Title;
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }




        }
}