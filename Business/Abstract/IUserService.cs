using Core.Entities.Concrete;
using Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetUserID(int id);

        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);

        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
