using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        //GetCarsByBrandId , GetCarsByColorId
        IDataResult<List<Car>> GetAll();

        IDataResult<List<CarDetailDto>> GetCarsDetailByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsDetailByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsDetailByBrandAndColorId(int brandId, int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailById(int id);
        IDataResult<List<CarDetailDto>> GetCarDetail();

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IResult AddTransactionalTest(Car car);
    }
}
