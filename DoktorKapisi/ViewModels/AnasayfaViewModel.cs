using DoktorKapisi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Mvc;

namespace DoktorKapisi.ViewModels
{
    public class AnasayfaViewModel
    {
        public List<SelectListItem> BolumListesi { get; set; }
        public List<Bolumler> SliderListesi { get; set; }
        public List<Yorumlar> YorumlarListesi { get; set; }
    }
}