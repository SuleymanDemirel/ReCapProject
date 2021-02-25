﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {


            var result = _rentalDal.GetAll().FindAll(r => r.ReturnDate == r.ReturnDate);

            if (result.Count > 0 && result.SingleOrDefault(r => r.CarId == rental.CarId) == default(Rental))
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.CarRentedSuccessfull);
            }
            else
            {
                return new ErrorResult(Messages.CarNotBeRented);
            }


        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(),Messages.CarsListed);
        }

        public IDataResult<Rental> GetRentalByCustomerId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.CustomerId == id));
        }

        public IDataResult<Rental> GetRentalById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentalId == id));
        }
    }
}