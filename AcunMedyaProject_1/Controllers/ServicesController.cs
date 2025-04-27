using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;
namespace AcunMedyaProject_1.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DBacunmedyaProject_1Entities db = new DBacunmedyaProject_1Entities();
        public ActionResult Index()
        {
            var values = db.TBL_Services.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult DeleteServices(int id)
        {
            var values = db.TBL_Services.Find(id);
            db.TBL_Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateServices(TBL_Services services)
        {
            db.TBL_Services.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateServices(int id)
        {
            var values = db.TBL_Services.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateServices(TBL_Services services)
        {
            var values = db.TBL_Services.Find(services.ServiceID);
            values.Description1 = services.Description1;
            values.Title = services.Title;
            values.ImageURL = services.ImageURL;
            values.Description2 = services.Description2;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        }
}