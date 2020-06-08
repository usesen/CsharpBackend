using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using FSMProduction.Entities.Concrete;

namespace FSMProduction.Business.ServiceContract.Wcf
{
    [ServiceContract]
    public interface IUserDetailService
    {
        [OperationContract]
        List<User> GetAll();
    }
}
