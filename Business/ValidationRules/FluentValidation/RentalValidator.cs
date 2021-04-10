using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentalId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
         
        }


    }
}
