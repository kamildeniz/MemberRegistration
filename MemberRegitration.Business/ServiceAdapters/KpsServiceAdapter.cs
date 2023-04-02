using MemberRegistration.Entities.Concrete;
using MemberRegitration.Business.KpsServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegitration.Business.ServiceAdapters
{
    public class KpsServiceAdapter : IKpsService
    {
        public bool ValidateUser(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
           return client.TCKimlikNoDogrula(Convert.ToInt64(member.TcNo),member.FirstName.ToUpper(),
                member.LastName.ToUpper(),Convert.ToInt32(member.DateOfBird.Year));
        }
    }
}
