using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name, Sex sex)
            : base(age, name, sex)
        {
            this.Sex = Sex.Male;
        }
    }
}
