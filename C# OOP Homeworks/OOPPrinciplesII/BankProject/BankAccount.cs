using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public abstract class BankAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public BankAccount(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interestRate must be positive number!");
                }

                this.interestRate = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.customer = value;
            }
        }

        public virtual void AddDeposit(decimal deposit)
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

        public virtual decimal InterestAmountForPeriod(uint mounts)
        {
            return (this.Balance * this.InterestRate) * mounts;
        }
    }
}
