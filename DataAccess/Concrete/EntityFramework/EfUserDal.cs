using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarDbContext>, IUserDal
    {
        public List<UserDetailDto> GetAllUserDetails()
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from u in  context.Users
                             join c in context.Customers
                             on u.Id equals c.CustomerId
                           



                             select new UserDetailDto
                             {
                                 Id = u.Id,
                                 CustomerId = c.CustomerId,
                                 Email = u.Email,
                                 CompanyName = c.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 FindeksPoint = c.FindeksPoint
                                 
                              
                                 
                                 


                             };
                return result.ToList();
            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

        public List<UserDetailDto> GetUserDetails(Expression<Func<User, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var result = from u in filter == null ? context.Users : context.Users.Where(filter)
                             join c in context.Customers
                             on u.Id equals c.CustomerId




                             select new UserDetailDto
                             {
                                Id= u.Id,
                                CustomerId = c.CustomerId,
                                Email = u.Email,
                                CompanyName = c.CompanyName,
                                FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 FindeksPoint = c.FindeksPoint


                             };
                return result.ToList();
            }
        }
    }
}
