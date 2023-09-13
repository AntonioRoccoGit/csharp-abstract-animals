using csharp_abstract_animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animal
{
    public class Sparrow : Animal, IFly, ISwim
    {
        public override void Eat()
        {
            Console.WriteLine("seeds, insects, fruit, mollusks}");
        }
        public override void Talk()
        {
            Console.WriteLine("Tweet - tweet");
        }
        public void Fly()
        {
            Console.WriteLine("Hope no eagle in the area");
        }
        public void Swim()
        {
            Console.WriteLine("I swim only for my life, damn predator");
        }
    }
}
