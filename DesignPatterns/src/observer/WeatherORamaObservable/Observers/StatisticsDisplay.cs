using WeatherORamaObservable.Subjects;

namespace WeatherORamaObservable.Observers;

public class StatisticsDisplay : IObserver<WeatherData>, IDisplayElement
{
    private double _maxTemperature;
    private double _minTemperature = 200;
    private double _temperatureSum;
    private int _numberOfReadings;
    private readonly IDisposable? _unsubscriber;

    public StatisticsDisplay(IObservable<WeatherData> weatherData)
    {
        _unsubscriber = weatherData?.Subscribe(this);
    }

    public void Display()
    {
        Console.WriteLine($"Max temperature: {_maxTemperature}°C");
        Console.WriteLine($"Min temperature: {_minTemperature}°C");
        Console.WriteLine($"Average temperature: {_temperatureSum / _numberOfReadings}°C");
    }

    public void OnCompleted()
    {
        Console.WriteLine($"=============================================================");
        Console.WriteLine($"=== Statistics Display has been successfully Unsubscribed ===");
        Console.WriteLine($"=============================================================\n");
        _unsubscriber?.Dispose();
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("Error occured {0}", error);
    }

    public void OnNext(WeatherData value)
    {
        _temperatureSum += value.Temperature;
        _numberOfReadings++;

        _maxTemperature = Math.Max(_maxTemperature, value.Temperature);
        _minTemperature = Math.Min(_minTemperature, value.Temperature);

        Display();
    }

    public override string? ToString()
    {
        return "Statistics Display";
    }
}
