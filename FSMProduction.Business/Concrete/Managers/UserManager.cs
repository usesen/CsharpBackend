using System.Collections.Generic;
using AutoMapper;
using FSMProduction.Business.Abstract;
using FSMProduction.Business.ValidationRules.FluentValidation;
using FSMProduction.Core.Aspect.PostSharp.AuthorizationAspect;
using FSMProduction.Core.Aspect.PostSharp.CacheAspect;
using FSMProduction.Core.Aspect.PostSharp.ExceptionAspects;
using FSMProduction.Core.Aspect.PostSharp.LogAspect;
using FSMProduction.Core.Aspect.PostSharp.PerformanceAspects;
using FSMProduction.Core.Aspect.PostSharp.TransactionAspect;
using FSMProduction.Core.Aspect.PostSharp.ValidationAspect;
using FSMProduction.Core.CrossCuttingConcerns.Logging.Log4Net.Layouts.Logger;
using FSMProduction.Core.CrossCuttingConcerns.Microsoft;
using FSMProduction.Core.Utilities.Mappings;
using FSMProduction.Entities.ComplexTypes;
using FSMProduction.Entities.Concrete;
using FSMProductionDataAccess.Abstract;
using PostSharp.Aspects.Dependencies;

namespace FSMProduction.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private readonly IMapper _mapper;
        
        public UserManager(IUserDal userDal,IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName & u.Password == password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }

       // [SecuredOperation(Roles = "Admin,Manager,Technican")]
        [ExceptionLogAspect]
        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(2)]
        [FluentValidationAspect(typeof(UserValidatior))]
        [LogAspect(typeof(FileLogger))]
        [LogAspect(typeof(DatabaseLogger))]
        public List<User> GetAll()
        {
            var users = _mapper.Map<List<User>>(_userDal.GetList());
            return users;
        }

        public User GetById(int id)
        {
            return _userDal.Get(p => p.Id == id);
        }

        public User Delete(User user)
        {
            return _userDal.Delete(user);
        }

        public User Add(User user)
        {
            return _userDal.Add(user);
        }

        public User Update(User user)
        {
            return _userDal.Update(user);
        }
    }
}
