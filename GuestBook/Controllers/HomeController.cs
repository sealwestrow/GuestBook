using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GuestBook.Models;

namespace GuestBook.Controllers
{
    public class HomeController : Controller
    {

        GuestContext db = new GuestContext();
        public ActionResult Index()
        {
            IEnumerable<Guest> guests = db.Guests;
            ViewBag.Guests = guests;
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            ViewBag.Browser = HttpContext.Request.Browser.Browser;
            ViewBag.IP = HttpContext.Request.UserHostAddress;
            return View();
        }
        [HttpPost]
        public string Add(Guest guest)
        {
            db.Guests.Add(guest);
            db.SaveChanges();
            return "Гость " + guest.Name + " был добавлен в книгу.";
        }
    }
}