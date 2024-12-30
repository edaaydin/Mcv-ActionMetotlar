using _07_MVC_ActionMetotlar.Models;
using Microsoft.AspNetCore.Mvc;

namespace _07_MVC_ActionMetotlar.Controllers
{
    public class BlogController : Controller
    {
        /*
        Actionlar; Uygulamadaki bir eyleme karsılık gelen operasyonları yoneten ve ardından islemin sonucuna gore kullanıcıya sonuc ureten metotlardır.
        
        Action verb.

        -Get : Bir kaynagın okunması veya alınması icin kullanılır. ornegin bir web sayfasını goruntulemek.
        -Post: Veri gondererek ve sunucuya kaydetmek icin kullanılır. Ornegin yeni bir kayıt olusturmak.
        -Put : Bir kaynagı güncellemek veya degistirmek icin kullanılır. Ozellikle RESTful API'lerde daha cok kullanılır.
        -Delete : Silme
        -Patch : Kısmı guncelleme.

         */
        public IActionResult Index()
        {
            // Action result
            // View : Bir gorunum sayfasını temsil eder. HTML cıktısı olusturmak icin kullanılır.
            //return View("Create");
            //return RedirectToAction("Index", "Home"); // Home/Index' e gider.

            // Content : Belirli bir metin dondurmek icin kullanılır.
            //return Content("merhaba dunya");

            //// Json : json dosyası dondurur.
            //var user = new { Name = "eda", Age = 22 };
            //return Json(user);

            // File : Dosya dondurur.
            //return File();

            // Status Code :

            return Ok();

            //return NotFound(); 404

            //return BadRequest(); 400
        }
        public IActionResult Create()
        {
            Blog blog = new Blog() { Name = "YZL-5101" };
            return View(blog);
        }

        [HttpPost]
        public IActionResult Create(string Head, string Article)
        {
            return Content($"Yazi kayit edildi...  Baslik : {Head} Makale : {Article}");
        }
    }
}
