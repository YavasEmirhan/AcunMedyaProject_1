using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaProject_1.Controllers //Admin layout controller.
{
    public class AdminLayoutController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()  
        {
            return PartialView();
        }
        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}