using Microsoft.AspNetCore.Mvc;

namespace OgrenciYonetimSistemi.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            return Content("Ogretmen modulu aktif");
        }
    }
}