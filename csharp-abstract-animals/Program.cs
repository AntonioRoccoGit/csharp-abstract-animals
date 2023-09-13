using csharp_abstract_animals.Animal;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle myEagle = new Eagle();
            myEagle.Sleep();
            myEagle.Fly();
            myEagle.Talk();
            myEagle.Eat();

        }
    }
}