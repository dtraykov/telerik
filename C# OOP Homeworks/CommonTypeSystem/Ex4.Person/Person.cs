using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4.Person
{
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
            : this(name, null)
        {
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must be specified!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age == null ? "Age is not specified." : this.Age.ToString());
        }
    }
}
