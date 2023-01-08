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
            new AbsensiViewModel(1, 002, new DateTime(2017, 8, 24, 08, 00, 0), new DateTime(2017, 8, 24, 17, 00, 0), "Bali", "Lupa"),
            new AbsensiViewModel(2, 003, new DateTime(2017, 8, 24, 08, 00, 0), new DateTime(2017, 8, 24, 17, 00, 0), "Denpasar", "Lupa"),
        };

        public IActionResult List()
        {
            return View(_absensiViewModels);
        }

        public IActionResult Edit(int? id)
        {
            AbsensiViewModel model = _absensiViewModels.Find(x=>x.Id.Equals(id));
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("Id, EmployeeId, AbsenStartDate, AbsenEndDate, Location, Description")] AbsensiViewModel absensi)
        {
            AbsensiViewModel absensiOld = _absensiViewModels.Find(x=>x.Id.Equals(id));
            _absensiViewModels.Remove(absensiOld);

            _absensiViewModels.Add(absensi);
            return Redirect("List");
        }

        public IActionResult Details(int id)
        {
            AbsensiViewModel absensi =(
                from p in _absensiViewModels
                where p.Id.Equals(id)
                select p).SingleOrDefault(new AbsensiViewModel());
            return View(absensi);
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            AbsensiViewModel absensi = _absensiViewModels.Find(x => x.Id.Equals(id));
            _absensiViewModels.Remove(absensi);
            return Redirect("List");
        }
    }
}
