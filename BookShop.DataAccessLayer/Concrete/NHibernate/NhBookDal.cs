using BookShop.DataAccessLayer.Abstract;
using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAccessLayer.Concrete.NHibernate
{
    public class NhBookDal : IBookDal
    {
        public void Add(Book entity)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            return new List<Book>()
            {
                new Book(){Id=1, Title="Nh Öğreniyorum", UnitPrice=1150},
                new Book(){Id=2, Title="Nh ile Tasarım", UnitPrice=1140},
                new Book(){Id=3, Title="Nh Connections", UnitPrice=1190},
            };
        }

        public void Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
