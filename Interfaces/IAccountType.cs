﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    public interface IAccountType
    {
        void CalculateInterest(Account account);
    }
}