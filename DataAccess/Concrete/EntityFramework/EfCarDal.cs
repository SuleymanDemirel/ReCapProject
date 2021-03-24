using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarDbContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car,bool>> filter =null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from p in filter == null? context.Cars : context.Cars.Where(filter)
                             join c in context.Brands
                             on p.BrandId equals c.BrandId
                             join z in context.Colors
                             on p.ColorId equals z.ColorId
                           

                             select new CarDetailDto
                             {
                                 Id = p.Id,
                                 CarName = p.CarName,
                                 BrandName = c.BrandName,
                                 DailyPrice = p.DailyPrice,
                                 ColorName = z.ColorName,
                                 Description = p.Description,
                                 ModelYear = p.ModelYear
                              
                             };
                return result.ToList();
            }
        }





    }
}
