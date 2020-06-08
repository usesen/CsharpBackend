using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;
using FSMProduction.Business.Abstract;
using FSMProduction.Entities.Concrete;

namespace WebApi.Controllers
{
    public class UsersController : ApiController
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        public List<User> Get()
        {
            return _userService.GetAll();
        }
    }
}
