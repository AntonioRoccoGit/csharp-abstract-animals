using csharp_abstract_animals.Animal;
using csharp_abstract_animals.Interface;
using System.Runtime.CompilerServices;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Eagle eagleA = new Eagle();
            Eagle eagleB = new Eagle();
            Eagle eagleC = new Eagle();
            Eagle eagleD = new Eagle();

            Sparrow sparrowA = new Sparrow();
            Sparrow sparrowB = new Sparrow();
            Sparrow sparrowC = new Sparrow();
            Sparrow sparrowD = new Sparrow();

            Dog dogA = new Dog();
            Dog dogB = new Dog();
            Dog dogC = new Dog();
            Dog dogD = new Dog();

            Dolphin dolphinA = new Dolphin();
            Dolphin dolphinB = new Dolphin();
            Dolphin dolphinC = new Dolphin();
            Dolphin dolphinD = new Dolphin();

            List<ISwim> swimmingAnimals = new List<ISwim>();
            swimmingAnimals.Add(eagleA);
            swimmingAnimals.Add(eagleB);
            swimmingAnimals.Add(eagleC);
            swimmingAnimals.Add(eagleD);

            swimmingAnimals.Add(sparrowA);
            swimmingAnimals.Add(sparrowB);
            swimmingAnimals.Add(sparrowC);
            swimmingAnimals.Add(sparrowD);

            swimmingAnimals.Add(dogA);
            swimmingAnimals.Add(dogB);
            swimmingAnimals.Add(dogC);
            swimmingAnimals.Add(dogD);

            swimmingAnimals.Add(dolphinD);
            swimmingAnimals.Add(dolphinD);
            swimmingAnimals.Add(dolphinD);
            swimmingAnimals.Add(dolphinD);


            List<IFly> flyingAnimals = new List<IFly>();
            flyingAnimals.Add(eagleA);
            flyingAnimals.Add(eagleB);
            flyingAnimals.Add(eagleC);
            flyingAnimals.Add(eagleD);

            flyingAnimals.Add(sparrowA);
            flyingAnimals.Add(sparrowB);
            flyingAnimals.Add(sparrowC);
            flyingAnimals.Add(sparrowD);

            foreach (var item in flyingAnimals)
            {
                MakeFly(item);
            }

            foreach (var item in swimmingAnimals)
            {
                MakeSwim(item);
            }


        }

        static void MakeFly(IFly item)
        {
            Console.WriteLine();
            Console.WriteLine($"Posso volare: ");
            item.Fly();
            Console.WriteLine();
        }

        static void MakeSwim(ISwim item)
        {
            Console.WriteLine();
            Console.WriteLine($"Posso nuotare: ");
            item.Swim();
            Console.WriteLine();
        }
    }
}