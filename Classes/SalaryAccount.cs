using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17
{
    public class SalaryAccount : IAccountType
    {
        public void CalculateInterest(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
