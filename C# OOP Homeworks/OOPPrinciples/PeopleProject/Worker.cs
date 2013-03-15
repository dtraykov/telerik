using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName)
            : this(firstName, lastName, 0, 8)
        {
        }

        public Worker(string firstName, string lastName, decimal weekSalary)
            : this(firstName, lastName, weekSalary, 8)
        {
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week salary must be a positive number.");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value > 24)
                {
                    throw new ArgumentException("Working hours per day must be less than 24.");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / (this.workHoursPerDay * 5);
        }

        public override string ToString()
        {
            return string.Format("{0}, Earned  money per hour: {1:C2}", base.ToString(), this.MoneyPerHour());
        }
    }
}
