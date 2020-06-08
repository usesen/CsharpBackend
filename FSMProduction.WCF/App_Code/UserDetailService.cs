using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FSMProduction.Business.DependencyResolvers.Ninject;
using FSMProduction.Business.ServiceContract.Wcf;
using FSMProduction.Entities.Concrete;

/// <summary>
/// Summary description for UserDetailService
/// </summary>
public class UserDetailService:IUserDetailService
{
    private IUserDetailService _userService = InstanceFactory.GetInstance<IUserDetailService>();
    public UserDetailService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<User> GetAll()
    {
        return _userService.GetAll();
    }
}