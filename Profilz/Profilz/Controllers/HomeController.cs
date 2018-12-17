using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Profilz.Controllers
{
    public class HomeController : Controller
    {
        public static Dictionary<string, string> myMenu = new Dictionary<string, string>();
        // GET: Home
        public ActionResult Index()
        {


            return View();
        }

        public ActionResult User1()
        {

            return View();
        }
        [HttpPost]
        public ActionResult User1(FormCollection collection)
        {
            ViewData["username"] = collection["username"];
            

            return View("User2");
        }

        public ActionResult userModel()
        {
            return View();
        }
    }
}