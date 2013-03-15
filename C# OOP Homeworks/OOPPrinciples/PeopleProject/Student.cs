using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
   public class Student : Human
    {
        private float grade;

        public Student(string firstName, string lastName, float grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public float Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grade must be a positive number.");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Grade: {1}", base.ToString(), this.grade);
        }
    }
}
