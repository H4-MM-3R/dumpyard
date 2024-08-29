using WeatherORamaObservable.Subjects;

namespace WeatherORamaObservable.Observers;

public class ForecastDisplay : IObserver<WeatherData>, IDisplayElement
{
    private double _currentPressure;
    private double _lastPressure;
    private readonly IDisposable? _unsubscriber;

    public ForecastDisplay(IObservable<WeatherData> weatherData)
    {
        _unsubscriber = weatherData?.Subscribe(this);
    }

    public void Display()
    {
        Console.Write("Forecast: ");
        Console.WriteLine(
            _currentPressure.CompareTo(_lastPressure) switch
            {
                > 0 => "Improving weather on the way!",
                0 => "More of the same",
                < 0 => "Watch out for cooler, rainy weather",
            }
        );
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        _lastPressure = _currentPressure;
        _currentPressure = pressure;

        Display();
    }

    public void OnCompleted()
    {
        Console.WriteLine($"===========================================================");
        Console.WriteLine($"=== Forecast Display has been successfully Unsubscribed ===");
        Console.WriteLine($"===========================================================\n");
        _unsubscriber?.Dispose();
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("Error occured {0}", error);
    }

    public void OnNext(WeatherData value)
    {
        _lastPressure = _currentPressure;
        _currentPressure = value.Pressure;

        Display();
    }

    public override string? ToString()
    {
        return "Forecast Display";
    }
}
