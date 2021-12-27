using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilBlogum.Models.Sınıflar;

namespace TatilBlogum.Controllers
{
      
    public class BlogController : Controller
    {
        Context c = new Context(); //context sınıfında c isimli nesne türetiyoruz.
        BlogYorum by = new BlogYorum();//blogyorum sınıfımızdan nesne türetiyoruz.
        // GET: Blog
        public ActionResult Index()
        {
            //var degerler = c.Blogs.ToList(); //veritabanından değer döndürüyoruz.

            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.Take(2).ToList(); //kaç tane blog alacağını gösterir.
            //by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList(); ID değerine göre descending olarak sıralama
            return View(by);
            
        }
       
        public ActionResult BlogDetay (int id)
        {
            //değer1: ilgili blog
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x=> x.Blogid == id).ToList();
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)//yorum yapılacak olan postun id sini alsın diye
        {
            ViewBag.deger = id;
            return PartialView();
        }
       
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }


    }
}