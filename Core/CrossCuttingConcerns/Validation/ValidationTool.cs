using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity) // hepsinin base'i object
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid) // geçersiz ise
            {
                throw new ValidationException(result.Errors);
            }


        }
    }
}
