using Profilz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Profilz.Controllers
{
    public class UserController : Controller
    {
        protected static Dal dal = Dal.Db;
        // GET: User
        public ActionResult Index()
        {
            return View(dal.Users.Local.ToList());
        }
    }
}