using BookShop.BusinessLayer.Abstract;
using BookShop.DataAccessLayer.Abstract;
using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BusinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {

        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
