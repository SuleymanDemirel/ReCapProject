using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using System.Linq;
using Core.Utilities.Business;
using Business.BusinessAspects.Autofac;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IRentalService _rentalService;
        public CarManager(ICarDal carDal,IRentalService rentalService)
        {
            _carDal = carDal;
            _rentalService = rentalService;
        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

            IResult result = BusinessRules.Run(CheckIfCarNameExists(car.CarName));
            if (result!=null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);//sistem bakımda
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<Car> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.BrandId == id));
        }

        public IDataResult<Car> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.ColorId == id));
        }

        public IResult Update(Car car)
        {
            //var result = _carDal.GetAll(c=>c.Id == car.Id).Count;
            //if (result >=10)
            //{
            //    return new ErrorResult(Messages.CarCountOfCategoryError);
            //}
            throw new NotImplementedException();
        }
        [ValidationAspect(typeof(CarValidator))]
        private IResult CheckIfCarNameExists(string carName)
        {
            var result = _carDal.GetAll(c => c.CarName == carName).Any(); // any bool döndürüyor. .Count ile de kontrol edebilirdik.
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
