using DoktorKapisi.Models.Entity;
using DoktorKapisi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoktorKapisi.Controllers
{
    public class RandevuAlController : Controller
    {
        DoktorKapisiEntities db = new DoktorKapisiEntities();
        // GET: RandevuAl
        public ActionResult Ara(int id)//bolumId'si gelecek
        {
            var doktorlar = db.Doktorlar.Where(x => x.BolumId == id).ToList();
          

            var model = new RandevuAlViewModel
            {
                DoktorListesi = doktorlar
            };

            return View(model);
        }
    }
}