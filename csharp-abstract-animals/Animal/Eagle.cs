﻿using csharp_abstract_animals.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animal
{
    public class Eagle : Animal, IFly, ISwim
    {
        public override void Eat()
        {
            Console.WriteLine("Meat");
        }
        public override void Talk()
        {
            Console.WriteLine("Screech - screech");

        }

        public void Fly()
        {
            Console.WriteLine("I believe i can flyyyyyy!!!");
        }

        public void Swim()
        {
            Console.WriteLine("I can swim to eat a better food");
        }
    }
}
