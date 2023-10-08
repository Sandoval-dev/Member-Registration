using DevFramework.Core.Aspects.Postsharp;
using MemberRegistiration.Business.Abstract;
using MemberRegistiration.Business.ServiceAdapters;
using MemberRegistiration.Business.ValidationRules.FluentValidation;
using MemberRegistiration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.Business.Concrete.Managers
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberdal;
        private IKpsService _kpsService;

        public MemberManager(IMemberDal memberdal, IKpsService kpsService)
        {
            _memberdal = memberdal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            if (_kpsService.ValidateUser(member)==false)
            {
                throw new Exception("Kullanıcı doğrulaması geçerli değil.");
            }

            _memberdal.Add(member);
        }
    }
}
