using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<RentalDetailDto>
    {
        public RentalValidator() 
        {
            RuleFor(r => r.FullName).NotEmpty();
            RuleFor(r => r.DailyPrice).NotEmpty();
            RuleFor(r=>r.DailyPrice).GreaterThan(0);
            RuleFor(r=>r.RentDate).NotEmpty();
            RuleFor(r=>r.ReturnDate).NotEmpty();
        }
    }
}
