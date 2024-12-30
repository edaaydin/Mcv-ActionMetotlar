using _07_MVC_ActionMetotlar.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace _07_MVC_ActionMetotlar.Controllers
{
    public class ProductController : Controller
    {
        private static IList<Product> _products;
        public ProductController()
        {
            if (_products == null)
            {
                _products = new List<Product>()
                {
                    new Product {
                        Id = 1,
                        Name = "Kalem1",
                        Stock = 10,
                        Price = 130,
                        Date = DateTime.Now
                    },
                        new Product {
                        Id = 2,
                        Name = "Kalem2",
                        Stock = 140,
                        Price = 120,
                        Date = DateTime.Now
                    },
                            new Product {
                        Id = 3,
                        Name = "Kalem3",
                        Stock = 160,
                        Price = 30,
                        Date = DateTime.Now
                    },
                };
            }
        }
        // Http Methods : Get, Post, Delete
        [HttpGet] // Default Deger : Selecct islemi icin kullanılır
        public IActionResult Index()
        {
            return View(_products);
        }

        // product/ create 
        [HttpGet] // 
        public IActionResult Create()
        {
            return View();
        }
        // Create formu submit oldugunda bu actiona dusecek.
        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid) // validation control
            {
                _products.Add(model); // product listesine ekleme yapıyoruz
                return RedirectToAction("Index"); // index actionuna return ediyoruz.
            }
            else
            {
                return View(model); // validation dogru degilse Create sayfasına tekrar don ama doldurulan verileri de ekranda goster.
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product model = _products.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Product model)
        {
            if (ModelState.IsValid)
            {
                Product product = _products.FirstOrDefault(x => x.Id == model.Id);

                product.Name = model.Name;
                product.Stock = model.Stock;
                product.Price = model.Price;

                return Redirect("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product model = _products.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Product model)
        {
            Product product = _products.FirstOrDefault(x => x.Id == model.Id);

            if (product != null)
            {
                _products.Remove(product);

                return RedirectToAction("Index");
            }
            else
            {
                return Content("Hatali Id");
            }


        }
    }
}
