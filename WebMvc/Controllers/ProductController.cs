using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;


namespace WebMvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult List()
        {
            List<ProductViewModel> productList = new List<ProductViewModel>()
            {
                new ProductViewModel(1, "Juz Mangga", "Minuman", 10000),
                new ProductViewModel(2, "Juz Alpukat", "Minuman", 10000),
                new ProductViewModel(3, "Mie Goreng Tante (Tanpa Telor)", "Makanan", 7500),
                new ProductViewModel(3, "Mie Goreng Telor", "Makanan", 15000),
                new ProductViewModel(4, "Es Teh Manis", "Minuman", 4000),
                new ProductViewModel(5, "Es Jeruk", "Minuman", 5000),
                new ProductViewModel(6, "Es Dawet Ayu", "Minuman", 5000)
            };

            return View(productList);
        }

        public IActionResult Details()
        {
            ProductViewModel product = new ProductViewModel(1, "Juz Mangga", "Minuman", 10000);
            return View(product);
        }
    }
}
