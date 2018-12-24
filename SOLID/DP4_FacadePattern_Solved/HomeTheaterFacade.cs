using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP4_FacadePattern_Solved
{
    class HomeTheaterFacade : IHomeTheaterFacade
    {
        private Amplifier amp;
        private Tuner tuner;
        private DvdPlayer dvd;
        private CdPlayer cd;
        private Television television;

        public HomeTheaterFacade()
        {
            amp = new Amplifier("Top-O-Line Amplifier");
            tuner = new Tuner("Top-O-Line AM/FM Tuner", amp);
            dvd = new DvdPlayer("Top-O-Line DVD Player", amp);
            cd = new CdPlayer("Top-O-Line CD Player", amp);
            television = new Television("Theater Screen");
        }

        public void WatchMovie()
        {
            television.On();
            television.WideScreenMode();
            amp.On();
            amp.SetDvd(dvd);
            amp.SetSurroundSound();
            amp.SetVolume(5);
            dvd.On();
            dvd.Play("The Avengers");
        }

    }
}
