using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal  _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccesResult(Messages.CarDeleted);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByCategoryId(int id)
        {
            return _carDal.GetAll(p => p.CategoryId == id);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetails()
        {
            throw new NotImplementedException();
        }

        public IResult UpDate(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        IDataResult<List<Car>> ICarService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
