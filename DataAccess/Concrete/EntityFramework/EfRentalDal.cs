using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositortyBase<Rental, KaanCenterContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail()
        {
            using (KaanCenterContext context = new KaanCenterContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals on c.Id equals r.CarId
                             join brand in context.Brands on c.BrandId equals brand.BrandId
                             join customer in context.Customers on r.CustomerId equals customer.UserId
                             select new RentalDetailDto
                             {
                                 FullName = customer.CompanyName,
                                 BrandName = brand.BrandName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
