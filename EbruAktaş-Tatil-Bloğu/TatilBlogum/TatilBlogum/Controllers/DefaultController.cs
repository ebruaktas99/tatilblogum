using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilBlogum.Models.Sınıflar;


namespace TatilBlogum.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context(); //Context sınıfından nesne türetiyoruz.Tablolarla işlem yapabilmek için.
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(5).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1() //Partialview: Bir işlemi birden fazla kez yapacaksak bir kalıp kullanırız.
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);

        }

        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 2).ToList(); //IDsi 1 olan blogu getirir.

            return PartialView(deger);
        }

        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList(); //ıDye göre büyükten küçüğe sırala
            return PartialView(deger);
        }


    }
}