using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class LoanAccount : BankAccount, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal InterestAmountForPeriod(uint mounts)
        {
            if (this.Customer.GetType().ToString() == "Individual")
            {
                if (mounts <= 3)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (mounts - 3);
                }
            }

            else
            {
                if (mounts <= 2)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (mounts - 2);
                }
            }
        }
    }
}
