using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class BankProjectTest
    {
        public static void Main(string[] args)
        {
            Company telerik = new Company("Telerik");
            Individual goshu = new Individual("Goshu", "Goshuv");

            DepositAccount goshuDepositAcount = new DepositAccount(goshu, 500m, 0.05m);
            DepositAccount telerikDepositAcount = new DepositAccount(telerik, 500m, 0.05m);
            goshuDepositAcount.Draw(200m);
            Console.WriteLine(goshuDepositAcount.Balance);
            goshuDepositAcount.AddDeposit(200);
            Console.WriteLine(goshuDepositAcount.Balance);

            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next six mounths: {3} ",
                goshuDepositAcount.GetType(), goshuDepositAcount.Customer.GetType(), goshuDepositAcount.Customer.Name, goshuDepositAcount.InterestAmountForPeriod(6));
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next six mounths: {3} ",
                telerikDepositAcount.GetType(), telerikDepositAcount.Customer.GetType(), telerikDepositAcount.Customer.Name, telerikDepositAcount.InterestAmountForPeriod(6));
            Console.WriteLine(new string('=', 80));

            LoanAccount goshuLoanAccount = new LoanAccount(goshu, 500m, 0.05m);
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next six mounths: {3} ",
                 goshuLoanAccount.GetType(), goshuLoanAccount.Customer.GetType(), goshuLoanAccount.Customer.Name, goshuLoanAccount.InterestAmountForPeriod(6));

            LoanAccount telerikLoanAccount = new LoanAccount(telerik, 500m, 0.05m);
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next six mounths: {3} ",
                 telerikLoanAccount.GetType(), telerikLoanAccount.Customer.GetType(), telerikLoanAccount.Customer.Name, telerikLoanAccount.InterestAmountForPeriod(6));
            Console.WriteLine(new string('=', 80));

            MortageAccount goshuMortageAccount = new MortageAccount(goshu, 500m, 0.05m);
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next two years: {3} ",
                goshuMortageAccount.GetType(), goshuMortageAccount.Customer.GetType(), goshuMortageAccount.Customer.Name, goshuMortageAccount.InterestAmountForPeriod(24));
            MortageAccount telerikMortageAccount = new MortageAccount(telerik, 500m, 0.05m);
            Console.WriteLine("The {0} of the {1}-{2} have interest amount for next two years: {3} ",
                 telerikMortageAccount.GetType(), telerikMortageAccount.Customer.GetType(), telerikMortageAccount.Customer.Name, telerikMortageAccount.InterestAmountForPeriod(24));
        }
    }
}
