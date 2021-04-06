using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
        //IDataResult<User> GetByMail(string email);

        IDataResult<List<UserDetailDto>> GetUserDetails(string email);
        IDataResult<List<UserDetailDto>> GetAllUserDetails();
        IDataResult<List<User>> GetAll();
    }
}
