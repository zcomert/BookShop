using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAccessLayer.Concrete.EntityFramework
{
    public class BookShopContext : DbContext
    {
        public BookShopContext()
        {
            Database.SetInitializer<BookShopContext>(null);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
