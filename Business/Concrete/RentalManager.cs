using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                return new ErrorResult(Messages.CarIsRented);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalSuccess);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetail(),Messages.RentalDtoListed);
        }

        public IDataResult<List<Rental>> GetRentalID(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.Id == id),Messages.RentalCarListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult RulesForAdding(Rental rental)
        {
            var result = BusinessRules.Run(
                CheckIfThisCarIsAlreadyRentedInSelectedDateRange(rental),
                CheckIfReturnDateIsBeforeRentDate(rental.ReturnDate, rental.RentDate));
            if (result != null)
            {
                return result;
            }
            return new SuccessResult(Messages.CarSuccessRented);
        }


        //Rules

        private IResult CheckIfThisCarIsAlreadyRentedInSelectedDateRange(Rental rental)
        {
            var result = _rentalDal.Get(r=>r.CarId == rental.CarId
            && (r.RentDate.Date == rental.RentDate.Date
            || (r.RentDate.Date < rental.RentDate.Date
            && (r.ReturnDate == null
            || ((DateTime)r.ReturnDate).Date > rental.RentDate.Date))));

            if (rental != null)
            {
                return new ErrorResult(Messages.ThisCarAlreadyRented);
            }

            return new SuccessResult();
        }

        private IResult CheckIfThisCarHasBeenReturned(Rental rental)
        {
            var result = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);
            if (rental != null)
            {
                if(rental.ReturnDate == null || rental.ReturnDate > rental.RentDate)
                {
                    return new ErrorResult(Messages.ThisCarAlreadyRented);
                }
            }

            return new SuccessResult();
        }

        private IResult CheckIfReturnDateIsBeforeRentDate(DateTime? returnDate , DateTime rentDate)
        {
            if (returnDate != null)
            {
                if (returnDate < rentDate)
                {
                    return new ErrorResult(Messages.ThisCarAlreadyRented);
                }
            }
            return new SuccessResult();
        }

    }
}
