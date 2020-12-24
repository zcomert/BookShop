using BookShop.DataAccessLayer.Abstract;
using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAccessLayer.Concrete.EntityFramework
{
    public class EfAuthorDal : EfRepositoryBase<Author,BookShopContext>, 
        IAuthorDal
    {
        
    }
}
