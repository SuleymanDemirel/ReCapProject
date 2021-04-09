using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarDbContext>, ICustomerDal
    {
        public List<CustomerDetailsDto> GetAllCustomerDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.CustomerId equals u.Id
                             select new CustomerDetailsDto
                             {
                                 CustomerId = c.CustomerId,
                                 UserId = c.UserId,
                                 CompanyName = c.CompanyName,
                                 CustomerName = u.FirstName + " " + u.LastName,
                                 Email = u.Email,
                                 FindeksPoint = c.FindeksPoint



                             };
                return result.ToList();
            }
        }

        public List<CustomerDetailsDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from c in filter == null ? context.Customers : context.Customers.Where(filter)
                             join u in context.Users
                             on c.CustomerId equals u.Id




                             select new CustomerDetailsDto
                             {
                                 CustomerId = c.CustomerId,
                                 UserId = c.UserId,
                                 CompanyName = c.CompanyName,
                                 CustomerName = u.FirstName + " " + u.LastName,
                                 Email = u.Email,
                                 FindeksPoint = c.FindeksPoint




                             };
                return result.ToList();
            }
        }
    }
}
