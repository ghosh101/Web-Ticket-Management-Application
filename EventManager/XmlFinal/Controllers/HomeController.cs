using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace XmlFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult BeforeAddEvent()
        {
           // ViewBag.Message = "Add Event";

            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {                      
            //Call Webservice
            if (username == password)
            {
                //return View("Index");
                return RedirectToAction("AddEvent");
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult AddEvent()
        {
            return View();
        }

        public ActionResult CancelTicket()
        {
            return View();
        }

        public ActionResult ConfirmCancel(string ticketId, string contactNo)
        {
            return View();
        }

        public ActionResult BookTicket(string CustomerName, string CustomerContactNo)
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}