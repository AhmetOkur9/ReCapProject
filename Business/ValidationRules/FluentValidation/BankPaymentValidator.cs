using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BankPaymentValidator:AbstractValidator<Payment>
    {
        public BankPaymentValidator()
        {
            RuleFor(p => p.FullName).NotEmpty();
            RuleFor(p => p.CardNumber).NotEmpty();
            RuleFor(p => p.CVV).NotEmpty();
            RuleFor(p => p.CustomerId).NotEmpty();
            RuleFor(p => p.CVV).LessThan(999);
            RuleFor(p => p.CVV).GreaterThan(0);
        }
    }
}
