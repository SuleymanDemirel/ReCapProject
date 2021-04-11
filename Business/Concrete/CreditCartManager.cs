using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CreditCartManager : ICreditCartService
    {
        ICreditCartDal _creditCartDal;
        public CreditCartManager(ICreditCartDal creditCartDal)
        {
            _creditCartDal = creditCartDal;
        }

        public IResult Add(CreditCart creditCart)
        {


            _creditCartDal.Add(creditCart);
                return new SuccessResult(Messages.CartAdded);
            
        }

        public IDataResult<CreditCart> GetCreditCartById(int id)
        {
           
                return new SuccessDataResult<CreditCart>(_creditCartDal.Get(c => c.CreditCartId == id));
            
        }
    }
}
