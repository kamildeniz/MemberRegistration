using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using MemberRegitration.Business.Abstract;
using MemberRegitration.Business.ServiceAdapters;
using MemberRegitration.Business.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegitration.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;
        public MemberManager(IMemberDal memberDal,IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))] 
        public void Add(Member member)
        {
            CheckIfMemberExists(member);
           
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Kullanıcı Doğrulaması Geçerli Değil");
            }
            _memberDal.Add(member);

            
        }
        private void CheckIfMemberExists(Member member)
        {
            if (_memberDal.Get(m => m.TcNo == m.TcNo) != null)
            {
                throw new Exception("Bu Kullanıcı Daha Önce Kayıt Olmuştur");
            }
        }
    }
}
