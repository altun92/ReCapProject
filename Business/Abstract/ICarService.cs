using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int carId);
        void Insert(Car car);
        void Delete(Car car);
        void Uptade(Car car);

    }
}
