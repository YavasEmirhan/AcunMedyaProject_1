using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;

namespace AcunMedyaProject_1.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            //view bag ile veri gönderme
            ViewBag.CategoryCount = dB.TBL_Category.Count(); // Count of categories
            ViewBag.TestimonialCount = dB.TBL_Testimonial.Count(); // Count of testimonials
            ViewBag.ProjectCount = dB.TBL_Project.Count(); // Count of projects
            

            return View();
        }
    }
}