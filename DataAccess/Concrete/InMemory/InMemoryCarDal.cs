using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        private object c;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 10, Description = "araba1", ModelYear = 2018},
                new Car{CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 20, Description = "araba2", ModelYear = 2020},
                new Car{CarId = 3, BrandId = 2, ColorId = 2, DailyPrice = 50, Description = "araba3", ModelYear = 2021},
            };
    }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrandId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Uptade(Car car)
        {
            //Gönderdiğim araç Id sine sahip olan listede ki aracı bul.
            Car carToUptade = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUptade.CarId = car.CarId;
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;
            carToUptade.CarName = car.CarName;
            carToUptade.BrandName = car.BrandName;
        }
    }
}
