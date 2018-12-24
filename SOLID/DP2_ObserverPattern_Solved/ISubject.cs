using DP2_ObserverPattern_Solved;

namespace WeatherStation
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(int temperature, int humidity, int pressure);
    }
}