using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class StudentController : Controller
    {
        private static List<StudentViewModel> _studentViewModels = new List<StudentViewModel>()
        {
            new StudentViewModel(1, "Mh rifai", 17, "boyolali", "IPA"),
            new StudentViewModel(2, "Mh rifai 2", 17, "Boyolali", "IPS"),
            new StudentViewModel(3, "Mh rifai 3", 18, "boyolali", "IPA"),
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("Id, StudentName, Age, Address, Jurusan")] StudentViewModel student)
        {
            _studentViewModels.Add(student);
            return Redirect("List");
        }

        public IActionResult List()
        {
            return View(_studentViewModels);
        }

        public IActionResult Edit(int? id)
        {
            StudentViewModel student = _studentViewModels.Find(x => x.Id.Equals(id));
            return View(student);
        }

        public IActionResult Update(int id, [Bind("Id, StudentName, Age, Address, Jurusan")] StudentViewModel student)
        {
            //hhapus data lama
            StudentViewModel studentOld = _studentViewModels.Find(x => x.Id.Equals(id));
            _studentViewModels.Remove(studentOld);

            _studentViewModels.Add(student);
            return Redirect("List");
        }

        public IActionResult Details(int id)
        {
            StudentViewModel employee = (
                from p in _studentViewModels
                where p.Id == id
                select p).SingleOrDefault(new StudentViewModel());
            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            StudentViewModel employee = _studentViewModels.Find(x => x.Id.Equals(id));
            _studentViewModels.Remove(employee);

            return RedirectToAction("List");
        }

    }
}
