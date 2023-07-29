using Core.Utilities.Result;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile formFile, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetImagesByCarId(int carId);
        IResult Transaction(CarImage carImage);
        IDataResult<List<CarImage>> GetDefaultImage(int carId);
    }
}
