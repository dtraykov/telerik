using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class DepositAccount : BankAccount, IDraw, IDeposit
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void AddDeposit(decimal deposit)
        {
            if (deposit < 0)
            {
                throw new ArgumentOutOfRangeException("The money you try to deposit are negative number!");
            }
            else
            {
                this.Balance += deposit;
            }
        }

        public void Draw(decimal drawMoney)
        {
            if (drawMoney < 0)
            {
                throw new ArgumentOutOfRangeException("The money you try to draw are negative number!");
            }
            else if (this.Balance - drawMoney < 0)
            {
                throw new ArgumentOutOfRangeException("After drew Balance is negative!");
            }
            else
            {
                this.Balance -= drawMoney;
            }
        }

        public override decimal InterestAmountForPeriod(uint mounts)
        {
            if (this.Balance <= 1000 && this.Balance >= 0)
            {
                return 0;
            }
            else
            {
                return base.InterestAmountForPeriod(mounts);
            }
        }
    }
}
