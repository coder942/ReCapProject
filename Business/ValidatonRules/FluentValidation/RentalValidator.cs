using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidatonRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().NotNull();
            RuleFor(r => r.CustomerId).NotEmpty().NotNull();
            RuleFor(r => r.RentDate).NotNull();
        }
    }
}
