using FacadePattern.Facade;
using FacadePattern.SubSystems;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tv = new Tv();
            var soundSystem = new SoundSystem();
            var lights = new Lights();

            var homeTheater = new HomeTheaterFacade(tv, soundSystem, lights);

            // Start watching a movie
            homeTheater.WatchMovie();

            // End the movie
            homeTheater.EndMovie();

            //-------------------------------------------------------------
            var bankingFacade = new BankingFacade();
            bankingFacade.TransferFunds("Acc123", "Acc456", 500.0);

            Console.ReadKey();
        }
    }
}
