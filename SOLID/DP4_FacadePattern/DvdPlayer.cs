using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP4_FacadePattern
{
    class DvdPlayer
    {
        private readonly string description;
        private int currentTrack;
        private Amplifier amplifier;
        private string movie;

        public DvdPlayer(string description, Amplifier amplifier)
        {
            this.description = description;
            this.amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine(description + " on");
        }

        public void Off()
        {
            Console.WriteLine(description + " off");
        }

        public void Eject()
        {
            movie = null;
            Console.WriteLine(description + " eject");
        }

        public void Play(string movie)
        {
            this.movie = movie;
            currentTrack = 0;
            Console.WriteLine(description + " playing \"" + movie + "\"");
        }

        public void Play(int track)
        {
            if (movie == null)
            {
                Console.WriteLine(description + " can't play track " + track + " no dvd inserted");
            }
            else
            {
                currentTrack = track;
                Console.WriteLine(description + " playing track " + currentTrack + " of \"" + movie + "\"");
            }
        }

        public void Stop()
        {
            currentTrack = 0;
            Console.WriteLine(description + " stopped \"" + movie + "\"");
        }

        public void Pause()
        {
            Console.WriteLine(description + " paused \"" + movie + "\"");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine(description + " set two channel audio");
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine(description + " set surround audio");
        }

        public override string ToString()
        {
            return description;
        }

    }
}
