using Microsoft.AspNetCore.Mvc;

namespace OgrenciYonetimSistemi.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return Content("Ogrenci modulu aktif - yeni guncelleme");
        }
    }
}