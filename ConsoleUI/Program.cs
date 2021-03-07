using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();
            //RentalCar();

            //GetRentalDetails();

        }

        //private static void GetRentalDetails()
        //{
        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());
        //    var result = rentalManager.GetRentalDetails();
        //    if (result.Success == true)
        //    {
        //        foreach (var rental in result.Data)
        //        {
        //            Console.WriteLine(rental.FirstName + " / " + rental.LastName + " / " + rental.CarName + " / " + rental.Email + " / " + rental.RentDate);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}

        //private static void RentalCar()
        //{
        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());
        //    var result = rentalManager.Add(new Rental
        //    {
        //        CarId = 6,
        //        CustomerId = 6,
        //        RentalId = 6,
        //        RentDate = new DateTime(2026, 06, 11),
        //        ReturnDate = new DateTime(2026, 06, 11)
        //    });
        //    if (result.Success == true)
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}

        //private static void CarManagerTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarDetails();
        //    if (result.Success == true)
        //    {
        //        foreach (var cars in result.Data)
        //        {
        //            Console.WriteLine(cars.CarName + " / " + cars.ColorName + " / " + cars.BrandName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}
    }
}
