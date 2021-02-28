using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.Id == 1);
            RuleFor(p => p.CarName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı.");// olmayan bir kural- Ürün ismi A ile başlamalı-Metotdur

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
