using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP4_FacadePattern
{
    class CdPlayer
    {
        private readonly String description;
        private int currentTrack;
        private Amplifier amplifier;
        private String title;

        public CdPlayer(String description, Amplifier amplifier)
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
            title = null;
            Console.WriteLine(description + " eject");
        }

        public void Play(String title)
        {
            this.title = title;
            currentTrack = 0;
            Console.WriteLine(description + " playing \"" + title + "\"");
        }

        public void Play(int track)
        {
            if (title == null)
            {
                Console.WriteLine(description + " can't play track " + currentTrack +
                                   ", no cd inserted");
            }
            else
            {
                currentTrack = track;
                Console.WriteLine(description + " playing track " + currentTrack);
            }
        }

        public void Stop()
        {
            currentTrack = 0;
            Console.WriteLine(description + " stopped");
        }

        public void Pause()
        {
            Console.WriteLine(description + " paused \"" + title + "\"");
        }

        public override string ToString()
        {
            return description;
        }

    }
}
