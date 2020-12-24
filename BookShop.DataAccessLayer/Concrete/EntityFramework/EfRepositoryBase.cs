using BookShop.DataAccessLayer.Abstract;
using BookShop.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAccessLayer.Concrete.EntityFramework
{
    public class EfRepositoryBase<Tentity, Tcontext> 
        : IEntityRepository<Tentity>
        where Tentity: class, IEntity, new()
        where Tcontext : DbContext, new()
    {
        public void Add(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            throw new NotImplementedException();
        }

        public Tentity Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tentity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Tentity entity)
        {
            throw new NotImplementedException();
        }
    }
}
