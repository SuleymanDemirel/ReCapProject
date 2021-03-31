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
        //public List<RentalDetailDto> GetRentalDetails()
        //{
        //    using (CarDbContext context = new CarDbContext())
        //    {


        //        var result = from r in context.Rentals
        //                     join c in context.Cars
        //                     on r.CarId equals c.CarId
        //                     join cs in context.Customers
        //                     on r.CustomerId equals cs.CustomerId
        //                     join u in context.Users
        //                     on cs.UserId equals u.Id
                           
        //                     select new RentalDetailDto
        //                     {
        //                         CarName =c.CarName,
        //                         CarId = c.Id,
        //                         RentDate = r.RentDate,
        //                         ReturnDate = r.ReturnDate,
        //                         RentalId = r.RentalId,
        //                         Id = c.Id
                               
                                 

        //                     };


        //        return result.ToList();


        //    }
        //}

        public List<RentalDetailDto> GetRentalDetailsDto(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {

                
                var result = from r in filter == null? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.Id
                           

                             select new RentalDetailDto
                             {

                                 CarName = c.CarName,
                                 CarId = c.Id,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 RentalId = r.RentalId,
                                 Id = c.Id,
                                 FirstName = r.FirstName


                             };
                return result.ToList();


            }
        }
    }
}
