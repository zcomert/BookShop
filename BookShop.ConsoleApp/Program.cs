using BookShop.BusinessLayer.Concrete;
using BookShop.DataAccessLayer.Concrete.EntityFramework;
using BookShop.DataAccessLayer.Concrete.ADONET;
using BookShop.DataAccessLayer.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.Entities.Concrete;

namespace BookShop.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var authorManager = new AuthorManager(new EfAuthorDal());
            var author = new Author()
            {
                AuthorId = 1,
                FirstName = "Zafer",
                LastName = "Aydın"
            };

            authorManager.Add(author);

            */

            var bookManager = new BookManager(new EfBookDal());
            var book = new Book()
            {
                Id = 1,
                Title = "OOP Learning",
                UnitPrice = 50,
                Author = new Author() { AuthorId = 1, FirstName = "Zafer", LastName = "Aydın" }
            };

            bookManager.Add(book);
            bookManager.GetAll().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
