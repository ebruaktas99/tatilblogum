using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TatilBlogum.Models.Sınıflar
{
    public class Context : DbContext //Context sınıfınfan miras alıyoruz tablolar için
    {

        public DbSet <Admin> Admins { get; set; } //Admins sınıfın veritabınındaki adı
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
    }
}