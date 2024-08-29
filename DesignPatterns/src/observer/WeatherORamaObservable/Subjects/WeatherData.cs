namespace WeatherORamaObservable.Subjects;

public class WeatherData : IObservable<WeatherData>
{
    private readonly List<IObserver<WeatherData>> _observers;

    public double Temperature { get; set; }
    public double Humidity { get; set; }
    public double Pressure { get; set; }

    public WeatherData()
    {
        _observers = new List<IObserver<WeatherData>>();
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(this);
        }
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }

    public IDisposable Subscribe(IObserver<WeatherData> observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
            Console.WriteLine($"=== Observer \"{observer}\" has been successfully Subscribed ===");
            Console.WriteLine();
        }
        return new UnSubsriber(_observers, observer);
    }

    private class UnSubsriber : IDisposable
    {
        private readonly List<IObserver<WeatherData>> _observers;
        private readonly IObserver<WeatherData> _observer;

        public UnSubsriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
