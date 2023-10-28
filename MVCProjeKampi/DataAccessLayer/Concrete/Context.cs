using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //DbContext aktif etmek için hatanın üzerine gelip
    //using.System.Data.Entity seçilir
    public class Context : DbContext

    {
        //Sınıfları dahil edebilmek için sağ tık 
        //using EntityLayer.Concrete eklenir
        //sql e yansıyacak tablolar
        public DbSet<About> Abouts { get; set; }
        //About sınıf ismi iken Abouts tablo ismi olacak
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
