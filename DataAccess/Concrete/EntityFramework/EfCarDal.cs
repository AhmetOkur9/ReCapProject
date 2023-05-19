using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetByCategoryId(int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
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
