using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class Cat : Animal, ISound
    {
        public Cat(int age, string name, Sex sex)
            : base(age, name, sex)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine("Miiiaaauuu!");
        }
    }
}
