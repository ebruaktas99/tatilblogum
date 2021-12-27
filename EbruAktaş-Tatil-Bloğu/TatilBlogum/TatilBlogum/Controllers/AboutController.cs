using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilBlogum.Models.Sınıflar;

namespace TatilBlogum.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c= new Context(); //context sınıfında c isimli nesne türetiyoruz.
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList(); //veritabanından değer döndürüyoruz.
            return View(degerler);
        }

        public ActionResult Bakk()
        {
            var degerler = c.Blogs.ToList(); //veritabanından değer döndürüyoruz.
            return View(degerler);
        }
      
    }
}