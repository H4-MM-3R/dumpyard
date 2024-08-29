using WeatherORama.Subjects;

namespace WeatherORama.Observers;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private double _maxTemperature;
    private double _minTemperature = 200;
    private double _temperatureSum;
    private int _numberOfReadings;

    // remove readonly if you want to implement the remove / unregister observer
    private readonly ISubject _weatherData;

    public StatisticsDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine($"Max temperature: {_maxTemperature}°C");
        Console.WriteLine($"Min temperature: {_minTemperature}°C");
        Console.WriteLine($"Average temperature: {_temperatureSum / _numberOfReadings}°C");
    }

    public void Update(double temperature, double humidity, double pressure)
    {
        _temperatureSum += temperature;
        _numberOfReadings++;

        _maxTemperature = Math.Max(_maxTemperature, temperature);
        _minTemperature = Math.Min(_minTemperature, temperature);

        Display();
    }

}
