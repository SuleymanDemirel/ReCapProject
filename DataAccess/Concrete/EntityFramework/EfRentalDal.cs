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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {


                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cs in context.Customers
                             on r.CustomerId equals cs.Id
                             join u in context.Users
                             on cs.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = r.RentalId,
                                 CarId = c.Id,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 CompanyName = cs.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }


        }

      
    }
}

