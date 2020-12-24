using BookShop.BusinessLayer.Concrete;
using BookShop.DataAccessLayer.Concrete.EntityFramework;
using BookShop.DataAccessLayer.Concrete.ADONET;
using BookShop.DataAccessLayer.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookManager = new BookManager(new NhBookDal());
            bookManager.GetAll().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
