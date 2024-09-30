using DoktorKapisi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoktorKapisi.ViewModels
{
    public class CombinedViewModel
    {
        public DoktorGirisViewModel GirisViewModel { get; set; }
        public DoktorGiris GirisModel { get; set; }
        public List<SelectListItem> BolumListesi { get; set; }
        public List<SelectListItem> SehirListesi { get; set; }
        public List<SelectListItem> CinsiyetListesi { get; set; }
    }
}
