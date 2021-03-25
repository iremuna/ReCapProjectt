using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(CarImage carImage)
        {
            var result = BusinessRules.Run(CheckCarImageLimitExceded(carImage.CarId));

            if (result != null)
            {
                return result;
            }

            TakeImagePath(carImage);

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.AddSuccess);
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.DeleteSuccess);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.ListSuccess);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarImage>> GetImagesCarById(int id)
        {

            var result = BusinessRules.Run(CheckCarImageCount(id));

            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(new List<CarImage> { new CarImage { ImagePath = "" } });
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id));
        }

        public IResult UpDate(CarImage carImage)
        {
            {
                var result = BusinessRules.Run(CheckCarImageLimitExceded(carImage.CarId));

                if (result != null)
                {
                    return result;
                }

                string newPath = TakeImagePath(carImage);
                carImage.ImagePath = newPath;
                _carImageDal.Update(carImage);
                return new SuccessResult(Messages.UpdateSuccess);
            }

            private string TakeImagePath(CarImage carImage1)
            {
                var newPath = Guid.NewGuid().ToString() + ".jpg";
                carImage.ImagePath = newPath;
                return newPath;
            }
            private IResult CheckCarImageLimitExceded(int id)
            {
                var result = _carImageDal.GetAll(c => c.CarId == id);
                if (result.Count >= 5)
                {
                    return new ErrorResult(Messages.CarImageLimitExceded);
                }
                return new SuccessResult();
            }
            private IResult CheckCarImageCount(int id)
            {
                var result = _carImageDal.GetAll(c => c.CarId == id).Count == 0;
                if (result)
                {
                    return new ErrorResult(Messages.NoCarImages);
                }
                return new SuccessResult();
            }

        }
    }
    }
}
