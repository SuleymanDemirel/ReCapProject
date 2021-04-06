using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public IDataResult<List<UserDetailDto>> GetUserDetails(string email)
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetUserDetails(c => c.Email == email));

        }

        public IDataResult<List<UserDetailDto>> GetAllUserDetails()
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetAllUserDetails());
        }
    }
}
