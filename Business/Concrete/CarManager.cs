using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }


        public IDataResult<List<Car>> GetAll()
        {
            //Business code
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(),Messages.CarListed);
        }
        

        public IResult AddTransactionalTest(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetailByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetailByBrandId(brandId), Messages.Succeed);
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetailByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetailByColorId(colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetailByBrandAndColorId(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetailBrandAndColorId(brandId, colorId), Messages.Succeed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailById(int id)
        {
            var result = _carDal.GetCarDetailById(id);
            if (result != null)
            {
                return new SuccessDataResult<List<CarDetailDto>>(result, Messages.Succeed);
            }
            return new ErrorDataResult<List<CarDetailDto>>(Messages.CarNotFound);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarsDetail(), Messages.CarDetailListed);
        }
    }
}
