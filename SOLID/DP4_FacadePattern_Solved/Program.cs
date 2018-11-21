using System;

namespace DP4_FacadePattern_Solved
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier("Top-O-Line Amplifier");
            Tuner tuner = new Tuner("Top-O-Line AM/FM Tuner", amp);
            DvdPlayer dvd = new DvdPlayer("Top-O-Line DVD Player", amp);
            CdPlayer cd = new CdPlayer("Top-O-Line CD Player", amp);
            Television television = new Television("Theater Screen");

            Console.WriteLine("Start watching movie 'The Avengers'");
            television.On();
            television.WideScreenMode();
            amp.On();
            amp.SetDvd(dvd);
            amp.SetSurroundSound();
            amp.SetVolume(5);
            dvd.On();
            dvd.Play("The Avengers");

            Console.WriteLine();
            Console.WriteLine("End movie");
            television.Off();
            amp.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();

            Console.WriteLine();
            Console.WriteLine("Listening to CD by Iron Maiden");
            amp.On();
            amp.SetVolume(5);
            amp.SetCd(cd);
            amp.SetStereoSound();
            cd.On();
            cd.Play("Iron Maiden - Live in Rio");

            Console.WriteLine();
            Console.WriteLine("Stop Listening to CD");
            amp.Off();
            amp.SetCd(cd);
            cd.Eject();
            cd.Off();

            Console.WriteLine();
            Console.WriteLine("Start listening to Radio");
            tuner.On();
            tuner.SetFrequency(89.12);
            amp.On();
            amp.SetVolume(5);
            amp.SetTuner(tuner);

            Console.WriteLine();
            Console.WriteLine("Stop listening to Radio");
            tuner.Off();
            amp.Off();

            Console.Read();
        }
    }
}
