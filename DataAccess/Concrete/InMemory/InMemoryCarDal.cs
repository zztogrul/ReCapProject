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
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{ Id=1, BrandId=2, ColorId=1, ModelYear=2015, DailyPrice= 150000, Description="Super"},
            new Car{ Id=2, BrandId=3, ColorId=3, ModelYear=2017, DailyPrice= 175000, Description="Kusursuz"},
            new Car{ Id=3, BrandId=1, ColorId=4, ModelYear=2018, DailyPrice= 200000, Description="Harika"},
            new Car{ Id=4, BrandId=4, ColorId=1, ModelYear=2020, DailyPrice= 250000, Description="Tam Kalite"},
            new Car{ Id=5, BrandId=2, ColorId=2, ModelYear=2022, DailyPrice= 300000, Description="Mükemmel"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
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

        public List<Car> GetById(int Id)
        {

            return _cars.Where(c => c.Id == Id).ToList();
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
