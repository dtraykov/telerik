using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Individual : Customer
    {
        private string lastName;

        public Individual(string name, string lastName)
            : base(name)
        {
            this.lastName = lastName;
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }
    }
}
