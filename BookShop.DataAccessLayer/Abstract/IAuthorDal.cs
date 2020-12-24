using BookShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAccessLayer.Abstract
{
    public interface IAuthorDal : IEntityRepository<Author>
    {
       
    }
}
