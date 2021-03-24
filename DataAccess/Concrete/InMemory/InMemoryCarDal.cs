using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        private List<Car> _car;
        

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{CarId= 1, Brandld= "BMW", Colorld ="Black", DailyPrice=100000, ModelYear =2010, Description="Konfor" },
                new Car{CarId= 2, Brandld= "Audi", Colorld ="Black", DailyPrice=150000, ModelYear =2012, Description="Pahalı" },
                new Car{CarId= 1, Brandld= "Toyoto", Colorld ="Gray", DailyPrice=1200, ModelYear =2017, Description="Orta Düzey" },


            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.Brandld = car.Brandld;
            carToUpdate.CarId = car.CarId;
            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.Colorld = car.Colorld;
            carToUpdate.DailyPrice = car.DailyPrice;

        }
        public List<Car> GetAllByCategory(int categoryId)
        {
            //Where içindeki koşula uyan tüm şeyleri döndürür
            return _cars.Where(prop => prop.CategoryId == categoryId).ToList();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }
    }
}
