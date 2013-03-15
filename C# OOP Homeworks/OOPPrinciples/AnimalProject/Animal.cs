using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public abstract class Animal
    {
        private int age;
        private string name;
        private Sex sex;

        public Animal(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public Sex Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
                this.sex = value;
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
                this.name = value;
            }
        }

        public int Age
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

        public static void GetAverageAge(Animal[] animals)
        {
            var speciesByAverageAge =
                            from animal in animals
                            group animal by animal.GetType() into a
                            select new { Species = a.Key.Name, AverageAge = a.Average(animal => animal.Age) };
            foreach (var item in speciesByAverageAge)
            {
                Console.WriteLine(item);
            }
        }

        public void IdentifyAnimal()
        {
            Console.WriteLine("I am {0}.", GetType().Name);
            Console.WriteLine("My name is:", this.name);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return string.Format("{0}: name = {1}, age = {2}, sex = {3}", this.GetType().Name, this.Name, this.Age, this.Sex);
        }
    }
}
