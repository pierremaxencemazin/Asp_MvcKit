using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Profilz.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int? id)
        {
            ViewData["errorCode"] = id.GetValueOrDefault(500);

            ViewData["errorPage"] = Request.QueryString["aspxerrorpath"];

            return View();
        }

        public ActionResult GetError(int? errorCode)
        {
            errorCode = errorCode.GetValueOrDefault(500);
            string partial;

            switch (errorCode)
            {

                case 404:
                    partial = "Error404";
                    break;

                default:
                    partial = "Error500";
                    break;
            }
            return PartialView(partial);
        }
    }
}