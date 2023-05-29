using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;

CarManager carManager = new CarManager(new EfCarDal());

//GetAll(carManager);



RentalManager rentalManager = new RentalManager(new EfRentalDal());
var result = rentalManager.GetAll();
if (result.Success == true)
{
    Console.WriteLine(result.Message);
    Console.WriteLine("------------------------------------------------------------------------");
    foreach (var rental in result.Data)
    {
        Console.WriteLine("Araç İd = {0} Kiralanma Tarihi = {1}", rental.CarId, rental.RentDate);
    }
}
else
{
    Console.WriteLine(result.Message);
}


var result1 = rentalManager.Add(new Rental
{
    CarId = 5,
    CustomerId = 2,
    RentDate = DateTime.Now,
    ReturnDate = new DateTime(2023, 5, 27)
});
Console.WriteLine(result1.Message);














//var result = carManager.GetCarDetails();
//if (result.Success==true)
//{
//    foreach (var car in result.Data)
//    {
//        Console.WriteLine(car.Description + " / " + car.ColorName);
//    }
//}
//else
//{
//    Console.WriteLine(result.Message);
//}



//foreach (var car in carManager.GetCarDetails().Data)
//{
//    Console.WriteLine(car.Description+ "/" + car.BrandName +  "/" + car.ColorName + "/" + car.DailyPrice);
//}



//static void GetAll(CarManager carManager)
//{
//    foreach (var car in carManager.GetAll().Data)
//    {
//        Console.WriteLine(car.Description);
//    }
//}