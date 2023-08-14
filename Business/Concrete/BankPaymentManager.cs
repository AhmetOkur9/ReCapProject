using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BankPaymentManager : IBankPaymentService
    {
        [ValidationAspect(typeof(BankPaymentValidator))]
        public IResult Payment(Payment payment)
        {
            return new SuccessResult(Messages.PaymentSuccess);
        }
    }
}
