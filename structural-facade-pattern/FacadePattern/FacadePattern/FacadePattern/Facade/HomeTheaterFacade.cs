using FacadePattern.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facade
{
    internal class HomeTheaterFacade
    {
        private readonly Tv _tv;
        private readonly SoundSystem _soundSystem;
        private readonly Lights _lights;

        public HomeTheaterFacade(Tv tv, SoundSystem soundSystem, Lights lights)
        {
            _tv = tv;
            _soundSystem = soundSystem;
            _lights = lights;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Preparing to watch a movie...");
            _lights.Dim();
            _tv.TurnOn();
            _tv.SetInput("HDMI1");
            _soundSystem.TurnOn();
            _soundSystem.SetVolume(10);
            Console.WriteLine("Movie is ready to watch!");
        }

        public void EndMovie()
        {
            _lights.Full();
            _tv.TurnOff();
            _soundSystem.TurnOff();
            Console.WriteLine("Shutting down home theater...");
            Console.WriteLine("Turning off all components.");
        }
    }
}
