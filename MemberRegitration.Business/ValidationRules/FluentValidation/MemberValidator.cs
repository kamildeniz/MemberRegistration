using FluentValidation;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegitration.Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m=>m.FirstName).NotEmpty();
            RuleFor(m=>m.LastName).NotEmpty();
            RuleFor(m=>m.DateOfBird).NotEmpty();
            RuleFor(m=>m.Email).NotEmpty();
            RuleFor(m=>m.TcNo).NotEmpty();
            RuleFor(m=>m.DateOfBird).LessThan(DateTime.Now);
            RuleFor(m=>m.Email).EmailAddress();
            RuleFor(m=>m.TcNo).Length(11);
        }
    }
}
