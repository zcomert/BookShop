using BookShop.DataAccessLayer.Abstract;
using BookShop.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAccessLayer.Concrete.ADONET
{
    public class AdoBookDal : IBookDal
    {
        public List<Book> GetAll()
        {
            return new List<Book>()
            {
                new Book(){Id=1, Title="Ado.Net Öğreniyorum", UnitPrice=50},
                new Book(){Id=2, Title="Ado.Net ile Tasarım", UnitPrice=40},
                new Book(){Id=3, Title="Ado.Net Connections", UnitPrice=90},
            };
        }
        public void Add(Book entity)
        {
        }

        public void Update(Book entity)
        {
        }
    }
}
