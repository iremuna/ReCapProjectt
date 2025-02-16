﻿using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        private object Messsages;

        public BrandManager(IBrandDal _brandDal)
        {
            _brandDal = _brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new IDataResult<List<Brand>>(_brandDal.GetAll(), Messsages.BrandListed);
        }

        public IResult UpDate(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
