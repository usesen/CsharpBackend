using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FSMProduction.Business.Abstract;
using FSMProduction.Entities.Concrete;
using FSMProduction.MVCWebUI.Models;

namespace FSMProduction.MVCWebUI.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

       
        public ActionResult Index()
        {
            var model = new UserListViewModel
            {
                Users = _userService.GetAll()
            };
            return View(model);
        }
        //public string Add()
        //{
        //    _userService.Add(new User
        //    {
        //        FirstName = "Tes",
        //        LastName = "Test_LastName",
        //        UserName = "Test_Username",
        //        UserFullName = "Test Test"
        //    });
        //    return "Added";
        //}

        //public string AddUpdate()
        //{
        //    {
        //        _userService.TransactionalOperation(new User
        //        {

        //            FirstName = "Ahmgfdgfdgfdgfdgd",
        //            LastName = "Ünlüeefdgfd",
        //            UserName = "UnluAsssgfdgfdgfdg",
        //            UserFullName = " Full Name"
        //        }, new User
        //        {
        //            Id = 4,
        //            FirstName = "Tesgfgfdgfdgfdgfdg",
        //            LastName = "Test_LastName-1",
        //            UserName = "Test_Username-1",
        //            UserFullName = "Full Full"
        //        });
        //        return "Done";
        //    }
        //}
    }
}