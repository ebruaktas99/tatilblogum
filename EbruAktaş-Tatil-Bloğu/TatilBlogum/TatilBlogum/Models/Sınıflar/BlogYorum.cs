using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TatilBlogum.Models.Sınıflar
{
    public class BlogYorum
    {
        /*Hangi tablolardan veri çekecek işlem gerçekleştireceksek 
        o tabloları buraya interface formatında yazmış oluyoruz.Bu sayede bir view içinde birden fazla 
        tablodan değer çekebilmiş oluyoruz.
        Ienumerable: Kolleksiyon*/

        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }




    }

}