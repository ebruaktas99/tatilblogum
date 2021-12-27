using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilBlogum.Models.Sınıflar;

namespace TatilBlogum.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context(); //context sınıfında c isimli nesne türetiyoruz.
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index(iletisim y)
        {
            c.iletisims.Add(y);
            c.SaveChanges();

            return View();
        }
    }
}