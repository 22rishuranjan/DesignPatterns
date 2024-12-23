

namespace FacadePattern.SubSystems
{
    internal class Tv
    {
        public void TurnOn() => Console.WriteLine("TV is turned on.");
       
        public void SetInput(string input) => Console.WriteLine($"TV input set to {input}.");

        public void TurnOff() => Console.WriteLine("TV is turned off.");

    }
}
