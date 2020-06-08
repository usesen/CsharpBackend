using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FSMProduction.Entities.Concrete;
using Ninject.Modules;

namespace FSMProduction.Business.ValidationRules.FluentValidation
{
    public class UserValidatior : AbstractValidator<User>
    {
        public UserValidatior()
        {
            //RuleFor(p => p.FirstName).NotEmpty().WithMessage("First Name cannot be empty");
            //RuleFor(p => p.LastName).NotEmpty().WithMessage("LastName Name cannot be empty");
            //RuleFor(p => p.FullName).NotEmpty().WithMessage("Full Name cannot be empty");
            //RuleFor(p => p.UserName).NotEmpty().WithMessage("User Name cannot be empty");
           // RuleFor(p => p.FirstName).Length(50).WithMessage("First Name cannot be greater than 50 characters");
           // RuleFor(p => p.LastName).Length(50).WithMessage("Second Name cannot be greater than 50 characters");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name cannot be empty")
                .Must(x => x.Length > 5 && x.Length < 50)
                .WithMessage("FirstName should be between 5 and 50 chars");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name cannot be empty")
                .Must(x => x.Length > 5 && x.Length < 50)
               
                .WithMessage("Full Name should be between 5 and 50 chars");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User Name cannot be empty")
                .Must(x => x.Length > 5 && x.Length < 50)
                .WithMessage("UserName should be between 5 and 50 chars");
        }
    }
}
