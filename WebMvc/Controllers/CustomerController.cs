using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;

namespace WebMvc.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private static List<CustomerViewModel> _customerListModels = new List<CustomerViewModel>()
        {
            new CustomerViewModel(1,"Mh rifai", "Denpasar", "Pria","Badung"),
            new CustomerViewModel(2,"Mh rifai 2", "Kuta Selatan", "Pria","Badung"),
        };

        public IActionResult List()
        {
            return View(_customerListModels);
        }

        public IActionResult Edit(int? id)
        {
            CustomerViewModel customer = _customerListModels.Find(x=>x.Id.Equals(id));
            return View(customer);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("Id, Name, Address, Gender, City")] CustomerViewModel customer)
        {
            CustomerViewModel customerOld = _customerListModels.Find(x => x.Id.Equals(id));
            _customerListModels.Remove(customerOld);

            _customerListModels.Add(customer);
            return Redirect("List");
        }

        public IActionResult Details(int id)
        {
            CustomerViewModel customer = (
                from p in _customerListModels
                where p.Id.Equals(id)
                select p
                ).SingleOrDefault(new CustomerViewModel());
            return View(customer);
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            try
            {
                CustomerViewModel customer = _customerListModels.Find(x => x.Id.Equals(id));

                _customerListModels.Remove(customer);

                return Redirect("List");
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
