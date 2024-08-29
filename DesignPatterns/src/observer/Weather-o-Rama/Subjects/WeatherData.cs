using WeatherORama.Observers;

namespace WeatherORama.Subjects;

public class WeatherData : ISubject
{
    private readonly List<IObserver> _observers;
    private double _temperature;
    private double _humidity;
    private double _pressure;

    public WeatherData()
    {
        _observers = new List<IObserver>();
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature, _humidity, _pressure);
        }
    }

    public void RegisterObserver(IObserver obsrvr)
    {
        _observers.Add(obsrvr);
    }

    public void RemoveObserver(IObserver obsrvr)
    {
        _observers.Remove(obsrvr);
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }
}
