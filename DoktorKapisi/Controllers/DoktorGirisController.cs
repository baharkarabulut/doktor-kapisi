using DoktorKapisi.Models.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace DoktorKapisi.Controllers
{
    public class DoktorGirisController : Controller
    {
        // GET: DoktorGiris
        [HttpGet]
        public ActionResult Index()
        {
            TempData["HataMesaji"] = "Kullanıcı adı veya şifre hatalı.";
            return View();
        }

        [HttpPost]
        public ActionResult Index(DoktorGiris p)
        {
            using (DoktorKapisiEntities db = new DoktorKapisiEntities())
            {
                var doktor = db.DoktorGiris.FirstOrDefault(x => x.Mail == p.Mail && x.Sifre == p.Sifre);
                if (doktor != null)
                {
                    // Giriş yaptıktan sonra DoktorController içindeki Index sayfasına yönlendir
                    GirisYapanDoktor.AktifDoktor = doktor;
                    FormsAuthentication.SetAuthCookie(doktor.Mail, false);
                    Session["Mail"] = doktor.Mail.ToString();
                    return RedirectToAction("Index", "Doktor");
                }
            }

            // Giriş başarısız ise, giriş sayfasına geri dön
            return RedirectToAction("Index", "DoktorGiris");
        }
    }

    // Bu sınıfı başka bir dosyada (örneğin GirisYapanDoktor.cs) saklayabilirsiniz.
    public static class GirisYapanDoktor
    {
        public static DoktorGiris AktifDoktor { get; set; }
    }
}
