using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FSMProduction.Business.Abstract;
using FSMProduction.Business.DependencyResolvers.Ninject;
using FSMProduction.Entities.ComplexTypes;
using FSMProduction.Entities.Concrete;

/// <summary>
/// Summary description for UserService
/// </summary>
public class UserService:IUserService
{
    public UserService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private IUserService _userService = InstanceFactory.GetInstance<IUserService>();

    public List<User> GetAll()
    {
        return _userService.GetAll();
    }

    public User GetById(int id)
    {
        throw new NotImplementedException();
    }

    public User Add(User user)
    {
        throw new NotImplementedException();
    }

    public User Update(User user)
    {
        throw new NotImplementedException();
    }

    public User Delete(User user)
    {
        throw new NotImplementedException();
    }

    public User GetByUserNameAndPassword(string userName, string password)
    {
        throw new NotImplementedException();
    }

    public List<UserRoleItem> GetUserRoles(User user)
    {
        throw new NotImplementedException();
    }

    public User Get(int id)
    {
        throw new NotImplementedException();
    }
}