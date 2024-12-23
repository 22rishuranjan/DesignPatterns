using BuilderPattern.implementation;
using BuilderPattern.orchestrator;
using System.IO;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new PizzaBuilder();
            var director = new PizzaOrchestrator(builder);

            var margherita = director.BuildMargheritaPizza();
            Console.WriteLine(margherita);

            var pepperoni = director.BuildPepperoniPizza();
            Console.WriteLine(pepperoni);
            Console.ReadKey();
        }
    }
}
