using System;

namespace DP4_FacadePattern_Solved
{
    class Amplifier
    {
        private readonly string description;
        private Tuner tuner;
        private DvdPlayer dvd;
        private CdPlayer cd;

        public Amplifier(String description)
        {
            this.description = description;
        }

        public void On()
        {
            Console.WriteLine(description + " on");
        }

        public void Off()
        {
            Console.WriteLine(description + " off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine(description + " stereo mode on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine(description + " surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine(description + " setting volume to " + level);
        }

        public void SetTuner(Tuner tunerDevice)
        {
            Console.WriteLine(description + " setting tuner to " + tunerDevice);
            tuner = tunerDevice;
        }

        public void SetDvd(DvdPlayer dvdPlayer)
        {
            Console.WriteLine(description + " setting DVD player to " + dvdPlayer);
            dvd = dvdPlayer;
        }

        public void SetCd(CdPlayer cdPlayer)
        {
            Console.WriteLine(description + " setting CD player to " + cdPlayer);
            cd = cdPlayer;
        }

        public override string ToString()
        {
            return description;
        }
    }
}
