﻿using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistiration.Business.ServiceAdapters
{
    public interface IKpsService
    {
        bool ValidateUser(Member member);
    }
}
