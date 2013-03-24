using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class MortageAccount : BankAccount, IDeposit
    {
        public MortageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal InterestAmountForPeriod(uint mounts)
        {
            if (this.Customer.GetType().ToString() == "Individual")
            {
                if (mounts <= 6)
                {
                    return 0;
                }
                else
                {
                    return (this.Balance * this.InterestRate) * (mounts - 6);
                }
            }
            else
            {
                if (mounts <= 12)
                {
                    return (this.Balance * (this.InterestRate / 2)) * (mounts);
                }
                else
                {
                    return (this.Balance * (this.InterestRate / 2)) * (mounts) + (this.Balance * this.InterestRate) * (mounts - 12);
                }
            }
        }
    }
}
