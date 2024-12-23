

namespace FacadePattern.SubSystems
{
    internal class SoundSystem
    {
        public void TurnOn() => Console.WriteLine("Sound system is turned on.");
        public void SetVolume(int level) => Console.WriteLine($"Sound system volume set to {level}.");
        public void TurnOff() => Console.WriteLine("Sound system is turned off.");

    }
}
