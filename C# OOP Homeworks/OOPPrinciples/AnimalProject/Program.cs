/* 3.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
 *Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
 *Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female 
 *and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of 
 *animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISound[] noisyCreatures = new ISound[]
                     {
                          new Dog(5, "Rex", Sex.Male),
                          new Kitten(3, "Whiskas", Sex.Female),
                          new Frog(8, "Kermit", Sex.Male),
                          new Dog(2, "Stella", Sex.Female),
                          new Tomcat(8, "Tommy", Sex.Female), // Tomcats are aways Male, and print sex = Male
                          new Kitten(5, "Maca", Sex.Female),
                     };

            foreach (ISound noisyCreature in noisyCreatures)
            {
                Console.WriteLine("{0}", noisyCreature.ToString());
                noisyCreature.ProduceSound();
                Console.WriteLine();
            }

            Animal[] animals = new Animal[]
                     {
                           new Dog(5, "Rex", Sex.Male),
                           new Kitten(3, "Whiskas", Sex.Female),
                           new Frog(8, "Kermit", Sex.Male),
                           new Dog(2, "Stella", Sex.Female),
                           new Tomcat(8, "Tommy", Sex.Female), 
                           new Kitten(5, "Maca", Sex.Female),
                     };

            Animal.GetAverageAge(animals);
        }
    }
}
