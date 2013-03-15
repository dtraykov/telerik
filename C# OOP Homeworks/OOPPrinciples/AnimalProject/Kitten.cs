using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class Kitten : Cat, ISound
    {
        public Kitten(int age, string name, Sex sex)
            : base(age, name, sex)
        {
            this.Sex = Sex.Female;
        }
    }
}
