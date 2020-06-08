using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Entities.ComplexTypes;
using FSMProduction.Entities.Concrete;
using Microsoft.SqlServer.Server;

namespace FSMProduction.Business.Abstract
{
    [ServiceContract]
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName, string password);
        List<UserRoleItem> GetUserRoles(User user);
        [OperationContract]
        List<User> GetAll();
        User GetById(int id);
        User Add(User user);
        User Update(User user);
        User Delete(User user);
    }
}
