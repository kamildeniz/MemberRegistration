using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using MemberRegitration.Business.Abstract;
using MemberRegitration.Business.ServiceAdapters;
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

        public void Add(Member member)
        {
            _memberDal.Add(member);
        }
    }
}
