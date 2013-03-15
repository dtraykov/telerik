using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolProject
{
    public class Student : Person
    {
        private int classNumber;

        public Student(string firstName, string lastName, int classNumber)
            : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                this.classNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Class number = {1}", base.ToString(), this.ClassNumber);
        }
    }
}
