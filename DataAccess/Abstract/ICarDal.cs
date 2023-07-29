using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarsDetail();
        List<CarDetailDto> GetCarsDetailByBrandId(int brandId);
        List<CarDetailDto> GetCarsDetailByColorId(int colorId);
        List<CarDetailDto> GetCarsDetailBrandAndColorId(int brandId, int colorId);
        List<CarDetailDto> GetCarDetailById(int carId);

        
    }
}
