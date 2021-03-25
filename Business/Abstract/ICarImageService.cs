using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage);
        IResult UpDate(CarImage carImage);
        IResult Delete(CarImage carImage);
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetImagesCarById(int id);

    }
}
