using csharp_abstract_animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animal
{
    public class Dog : Animal, ISwim
    {
        public override void Eat()
        {
            Console.WriteLine("Kibble");
        }
        public override void Talk()
        {
        Console.WriteLine("Woof - woof");
        }   
        public void Swim()
        {
            Console.WriteLine("I can't do it John!");
        }

    }
    
}
