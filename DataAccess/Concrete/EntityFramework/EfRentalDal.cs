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
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {


                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join cstmr in context.Customers
                             on r.CustomerId equals cstmr.UserId
                             join u in context.Users
                             on cstmr.UserId equals u.Id

                             select new RentalDetailDto
                             {
                             Id = u.Id,
                             RentDate = r.RentDate,
                             ReturnDate = r.ReturnDate,
                             CarId = r.CarId,
                             UserId = cstmr.UserId,
                             RentalId = r.RentalId,
                             FirstName = u.FirstName,
                             CompanyName = cstmr.CompanyName,
                             CustomerId = r.CustomerId,
                             Email = u.Email,
                             LastName = u.LastName,
                             Password = u.Password,
                             CarName = c.CarName
                             

                             };
                return result.ToList();


            }
        }
    }
}
