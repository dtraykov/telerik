using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("The first name of Person can't be empty or less than 2 letters!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("The last name of Person can't be empty or less than 2 letters!");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.firstName, this.lastName);
        }
    }
}
