using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilBlogum.Models.Sınıflar;
namespace TatilBlogum.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        { 
            //sayfa yüklendiğinde hiçbir şey yapma sadece sayfanın boş halini gönder

            return View();
        }

        [HttpPost] //sayfada yapılan işlemler geri döndürülsün.
        public ActionResult YeniBlog(Blog p) //yeniblog isimleri aynı olduğu için hem de geri döndürülecek değer için parametre verdik.
        {
            c.Blogs.Add(p); //parametreden gelen değerleri bloglara ekle.Parametreye değerler txtboxtan gelecek.
            c.SaveChanges(); //değişiklikleri kaydet.
            return RedirectToAction("Index"); //Index aksiyonuna yönlendir.
        }

        public ActionResult BlogSil(int id) //Admin Panelinden bloğu silebilmek için
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id) //Admın panelinde blogları güncellemek için
        {   var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl); //blog getir sayfasını ve bl den gelen değeri getir.
        }

        public ActionResult BlogGüncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID); //b den gönderdiğimiz IDye göre ilgili bloğu bul.
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi() //admin paneline yorumları götürmek için.
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id) //Admin Panelinden yorumu silebilmek için
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();

            return RedirectToAction("YorumListesi");
        }
         
        public ActionResult YorumGetir(int id) //Admin panelinde yorumları güncellemek için yorumları getiriyoruz.

        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }

        public ActionResult YorumGüncelle(Yorumlar y) //yorumları güncelleme işlemi
        {
            var yrm = c.Yorumlars.Find(y.ID); //y den gönderdiğimiz IDye göre ilgili yorumu bul.
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();

            return RedirectToAction("YorumListesi");
        }

    }
}