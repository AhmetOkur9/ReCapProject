using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                return filter == null
                ? context.Set<Brand>().ToList()
                : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public List<Brand> GetByCategoryId(int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
