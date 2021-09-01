using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            carManager.Add(new Car { Id = 6, BrandId = 3, ColorId = 2, DailyPrice = 40000, Description = "SUV", ModelYear = 2004 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car price = " + car.DailyPrice + " TL'dir." + car.Description + " türündedir." );
            }

        }
    }
}
