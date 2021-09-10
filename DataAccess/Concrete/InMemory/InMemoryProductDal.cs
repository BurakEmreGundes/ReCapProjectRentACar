using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryProductDal()
        {
            _cars = new List<Car>()
            {
                new Car(){Id=1,BrandId=1,ColorId=1,DailyPrice=50,Description="Mercedes is a good car.",ModelYear=2021},
                new Car(){Id=2,BrandId=2,ColorId=2,DailyPrice=150,Description="BMW is a good car.",ModelYear=2021},
                new Car(){Id=3,BrandId=3,ColorId=3,DailyPrice=250,Description="Ford is a good car.",ModelYear=2021 },
                new Car(){Id=4,BrandId=4,ColorId=4,DailyPrice=350,Description="Ferrari is a good car.",ModelYear=2021 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carForDelete=_cars.SingleOrDefault(c => c.Id == car.Id);

           _cars.Remove(carForDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carForUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carForUpdate.BrandId = car.BrandId;
            carForUpdate.ColorId = car.ColorId;
            carForUpdate.DailyPrice = car.DailyPrice;
            carForUpdate.ModelYear = car.ModelYear;
            carForUpdate.Description = car.Description;
        }
    }
}
