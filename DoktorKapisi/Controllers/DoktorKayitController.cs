using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using DoktorKapisi.Models.Entity;
using DoktorKapisi.ViewModels;

namespace DoktorKapisi.Controllers
{
    public class DoktorKayitController : Controller
    {
        // GET: DoktorKayit
        DoktorKapisiEntities db = new DoktorKapisiEntities();
        [HttpGet]
        public ActionResult Kayit()
        {
            var bolumler = db.Bolumler.ToList();

            var sehirler = db.Sehirler.ToList();

            var cinsiyet = db.Cinsiyet.ToList();

            var bolumlerList = new List<SelectListItem>();

            var sehirlerList = new List<SelectListItem>();

            var cinsiyetList = new List<SelectListItem>();

            foreach (var bolum in bolumler)
            {
                bolumlerList.Add(new SelectListItem { Value = bolum.id.ToString(), Text = bolum.BolumAdi });
            }
            foreach (var sehir in sehirler)
            {
                sehirlerList.Add(new SelectListItem { Value = sehir.Id.ToString(), Text = sehir.Sehir });
            }

            foreach (var cins in cinsiyet)
            {
                cinsiyetList.Add(new SelectListItem { Value = cins.Id.ToString(), Text = cins.Gender });
            }

            var model = new DoktorGirisViewModel
            {
                BolumListesi = bolumlerList,

                SehirListesi = sehirlerList,

                CinsiyetListesi = cinsiyetList
            };

            return View(model);
        }


        [HttpPost]
        public ActionResult Kayit(DoktorGiris p)
        {
            db.DoktorGiris.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","DoktorGiris");
        }
    }
}