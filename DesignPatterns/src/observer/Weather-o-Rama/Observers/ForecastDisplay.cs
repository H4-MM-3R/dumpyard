using WeatherORama.Subjects;

namespace WeatherORama.Observers;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private double _currentPressure;
    private double _lastPressure;

    // remove readonly if you want to implement the remove / unregister observer
    private readonly ISubject _weatherData;

    public ForecastDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
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
}
