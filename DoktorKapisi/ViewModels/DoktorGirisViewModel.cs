using DoktorKapisi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoktorKapisi.ViewModels
{
    public class DoktorGirisViewModel
    {
        public List<SelectListItem> BolumListesi { get; set; }
        public List<Sehirler> SehirListesi { get; set; }
        public List<Cinsiyet> CinsiyetListesi { get; set; }
    }
}