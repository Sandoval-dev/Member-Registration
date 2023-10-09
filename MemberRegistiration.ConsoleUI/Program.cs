using MemberRegistiration.Business.Abstract;
using MemberRegistiration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMemberService memberService=InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                FirstName="Osman Erdem",
                LastName="Kılıç",
                TcNo="34348048790",
                Email="osmankilic10@gmail.com",
                DateOfBirth=new DateTime(2000,06,05)

            });

            Console.WriteLine("Eklendi.");
            Console.ReadLine();
        }
    }
}
