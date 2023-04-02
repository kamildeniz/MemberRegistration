using MemberRegistration.Entities.Concrete;
using MemberRegitration.Business.Abstract;
using MemberRegitration.Business.DeppendencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMemberService memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member { Email="kamil07deniz@gmail.com",FirstName="Kamil",LastName="Deniz",DateOfBird=new DateTime(1995,03,24),TcNo="52042079728" });
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
