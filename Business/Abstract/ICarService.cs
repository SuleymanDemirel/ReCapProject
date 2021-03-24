using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
       
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId);
        IDataResult<Car> GetCarsByCarId(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult AddTransactionalTest(Car car);
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int id);

        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int id);
    }
}
