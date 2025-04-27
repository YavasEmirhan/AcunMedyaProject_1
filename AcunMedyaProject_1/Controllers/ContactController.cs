using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models;

namespace AcunMedyaProject_1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DBacunmedyaProject_1Entities dB = new DBacunmedyaProject_1Entities(); // Database context
        public ActionResult Index()
        {
            var values = dB.TBL_Contact.ToList(); // Fetching all contact records from the database
            return View(values);
        }
        [HttpGet]
        public ActionResult DeleteContact(int id)
        {
            var values = dB.TBL_Contact.Find(id); // Finding the contact record by id
            dB.TBL_Contact.Remove(values); // Removing the contact record from the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(TBL_Contact contact)
        {
            dB.TBL_Contact.Add(contact); // Adding the new contact record to the database
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var values = dB.TBL_Contact.Find(id); // Finding the contact record by id
            return View(values); // Returning the contact record to the view
        }
        [HttpPost]
        public ActionResult UpdateContact(TBL_Contact model)
        {
            var values = dB.TBL_Contact.Find(model.ContactID); // Finding the contact record by id
            values.Description = model.Description; // Updating the contact description
            values.Adress = model.Adress; // Updating the contact address
            values.Email = model.Email; // Updating the contact email
            values.Phone = model.Phone; // Updating the contact phone number
            dB.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        }
}