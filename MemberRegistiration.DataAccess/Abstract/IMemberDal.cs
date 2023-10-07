using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.DataAccess;

namespace MemberRegistiration.DataAccess.Abstract
{
    public interface IMemberDal:IEntityRepository<Member>
    {

    }
}
