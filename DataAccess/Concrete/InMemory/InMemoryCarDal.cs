using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car= new List<Car> { 
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150,Description="Sıfır Araba",ModelYear=2017 },
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=300,Description="Az Kullanılmış Araba",ModelYear=2019 },
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=245,Description="Aile Dostu Araba",ModelYear=2021 },
                new Car{Id=4,BrandId=3,ColorId=2,DailyPrice=365,Description="Hızlı Araba",ModelYear=2020 },
                new Car{Id=5,BrandId=3,ColorId=2,DailyPrice=483,Description="Lüks Araba",ModelYear=2023 },
                new Car{Id=6,BrandId=1,ColorId=1,DailyPrice=100,Description="Ucuz Araba",ModelYear=2016 },
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeletedToCar = _car.SingleOrDefault(c=>c.Id == car.Id);
            _car.Remove(DeletedToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCategoryId(int carId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car UpdatedToCar= _car.SingleOrDefault(c=> c.Id == car.Id);
            UpdatedToCar.Id = car.Id;
            UpdatedToCar.BrandId = car.BrandId;
            UpdatedToCar.ColorId = car.ColorId;
            UpdatedToCar.DailyPrice = car.DailyPrice;
            UpdatedToCar.Description=car.Description;
            UpdatedToCar.ModelYear = car.ModelYear;
        }
    }
}
