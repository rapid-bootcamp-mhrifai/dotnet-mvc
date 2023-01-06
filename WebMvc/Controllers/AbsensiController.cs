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
            new AbsensiViewModel(1, 002, '01/01/2023', '01/01/2023', "Bali", "Lupa"),
        };
    }
}
