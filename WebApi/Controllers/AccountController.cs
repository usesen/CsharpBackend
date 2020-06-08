using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using FSMProduction.Business.Abstract;
using FSMProduction.Core.CrossCuttingConcerns.Security.Web;
using FSMProduction.Entities.Concrete;

namespace WebApi.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public   string Login(string userName, string password)
        {
            var user = _userService.GetByUserNameAndPassword(userName, password);
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(), user.UserName,
                    user.Email,
                    DateTime.Now.AddDays(60),
                    _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray(),
                    false,
                    user.FirstName,
                    user.LastName);
                return "User is authenticated!";
            }
            return "User is NOT authenticated!";
        }

        public List<User> GetUsers()
        {
            return   _userService.GetAll();
        }

        public User GetById(int id)
        {
            return _userService.GetById(p => p.Id == id);
        }
    }
}
