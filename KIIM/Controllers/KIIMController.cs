using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KIIM.Controllers
{
    public class KIIMController : Controller
    {
        //
        // GET: /KIIM/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }
	}
}