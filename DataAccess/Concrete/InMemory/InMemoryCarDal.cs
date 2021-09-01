using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id=1 , BrandId = 1 , ColorId=1 , DailyPrice = 20000 , Description="Old Car", ModelYear = 1999 },
                new Car{Id=2 , BrandId = 4 , ColorId=3 , DailyPrice = 15555 , Description="Cheap Car", ModelYear = 2003 },
                new Car{Id=3 , BrandId = 2 , ColorId=2 , DailyPrice = 200000 , Description="Sports Car", ModelYear = 2012 },
                new Car{Id=4 , BrandId = 3 , ColorId=4 , DailyPrice = 75000, Description="Family Car", ModelYear = 2008 },
                new Car{Id=5 , BrandId = 5 , ColorId=5 , DailyPrice = 48000 , Description="Jepp", ModelYear = 2005 }
            };
        
        }
        
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
