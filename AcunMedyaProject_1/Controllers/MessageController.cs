using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaProject_1.Models; // Assuming you have a Models folder for your models
namespace AcunMedyaProject_1.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        DBacunmedyaProject_1Entities db = new DBacunmedyaProject_1Entities();
        public ActionResult Index()
        {
            var values = db.TBL_Message.ToList(); // Fetching all messages from the database
            return View(values);
        }
        [HttpGet]
        public ActionResult DeleteMessage(int id)
        {
            var values = db.TBL_Message.Find(id); // Finding the message by id
            db.TBL_Message.Remove(values); // Removing the message from the database
            db.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult CreateMessage()
        {
            return View();
        }
        public ActionResult CreateMessage(TBL_Message Message)
        {
            db.TBL_Message.Add(Message); // Adding the new message to the database
            db.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }
        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var values = db.TBL_Message.Find(id); // Finding the message by id
            return View(values); // Returning the message to the view
        }
        [HttpPost]
        public ActionResult UpdateMessage(TBL_Message model)
        {
            var values = db.TBL_Message.Find(model.MessageID); // Finding the message by id
            values.NameSurname = model.NameSurname; // Updating the name and surname
            values.Mail = model.Mail; // Updating the email
            values.Subject = model.Subject; // Updating the subject
            values.MessageContent = model.MessageContent; // Updating the message content
            db.SaveChanges(); // Saving changes to the database
            return RedirectToAction("Index"); // Redirecting to the index action
        }



        }
}