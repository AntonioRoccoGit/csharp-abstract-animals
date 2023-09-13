using csharp_abstract_animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animal
{
    public class Dolphin : Animal, ISwim
    {
        public override void Eat()
        {
            Console.WriteLine("Fishes, squids");
        }
        public override void Talk()
        {
            Console.WriteLine("Eeeheeehee  - eeheeehee ");
        }
        public void Swim()
        {
            Console.WriteLine("If im not a dolphin, who is then? --swim away!!!");

        }

    }
}
