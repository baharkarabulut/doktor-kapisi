using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoktorKapisi.Controllers
{
    public class DoktorController : Controller
    {
        // GET: Doktor
        public ActionResult Index()
        {
            return View();
        }
    }
}