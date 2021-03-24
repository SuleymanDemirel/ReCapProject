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
        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
               
                var result = context.Cars
                    .Include(i => i.Brand)
                    .Include(i => i.Color)
                    .Include(i => i.CarImages)
                    .Select(s => new CarDetailDto
                    {
                        Id = s.Id,
                        BrandName = s.Brand.BrandName,
                        ColorName = s.Color.ColorName,
                        Description = s.Description,
                        DailyPrice = s.DailyPrice,
                        ModelYear = s.ModelYear,
                        CarName = s.CarName,
                        ImagePath = s.CarImages.Select(sk => sk.ImagePath).ToList()

                    }).ToList();
                return result;
            }
        }

        public List<CarDetailDto> GetSingleCarDetail(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = context.Cars
                    .Where(filter)
                    .Include(i => i.Brand)
                    .Include(i => i.Color)
                    .Include(i => i.CarImages)
                    .Select(s => new CarDetailDto
                    {
                        Id = s.Id,
                        BrandName = s.Brand.BrandName,
                        ColorName = s.Color.ColorName,
                        Description = s.Description,
                        DailyPrice = s.DailyPrice,
                        ModelYear = s.ModelYear,
                        CarName = s.CarName,
                        ImagePath = s.CarImages.Select(sk => sk.ImagePath).ToList()

                    }).ToList();
                return result;
            }
        }

    }
}
