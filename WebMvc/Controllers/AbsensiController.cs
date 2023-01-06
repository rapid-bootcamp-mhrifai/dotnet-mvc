using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class AbsensiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private static List<AbsensiViewModel> _absensiViewModels = new List<AbsensiViewModel>()
        {
            new AbsensiViewModel(1, 001, 2015, 12, 31, 2015, 12, 31, "Bali", "Absen"),
        };
    }
}
