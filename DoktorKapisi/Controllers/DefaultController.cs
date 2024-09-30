using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoktorKapisi.Models.Entity;
using DoktorKapisi.ViewModels;

namespace DoktorKapisi.Controllers
{
    public class DefaultController : Controller
    {
        DoktorKapisiEntities db = new DoktorKapisiEntities();
        // GET: Default
        public ActionResult Index()
        {
            var bolumler = db.Bolumler.ToList();

            var yorumlar = db.Yorumlar.ToList();

            var bolumlerList = new List<SelectListItem>();

            foreach (var bolum in bolumler)
            {
                bolumlerList.Add(new SelectListItem { Value = bolum.id.ToString(), Text = bolum.BolumAdi });
            }

            var model = new AnasayfaViewModel
            {
                BolumListesi = bolumlerList,
                SliderListesi = bolumler.ToList(),
                YorumlarListesi = yorumlar.ToList()
            };

            return View(model);
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult RandevuAl()
        {
            return View();
        }

        public ActionResult DoktorMusunuz()
        {
            return View();
        }
        
        public ActionResult DoktorGiris()
        {
            return View();
        }
    }
}