using WeatherORamaObservable.Subjects;

namespace WeatherORamaObservable.Observers;

public class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplayElement
{
    private double _temperature;
    private double _humidity;
    private readonly IDisposable? _unsubscriber;

    public CurrentConditionsDisplay(IObservable<WeatherData> weatherData)
    {
        _unsubscriber = weatherData?.Subscribe(this);
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}°C, {_humidity}% humidity");
    }

    public void OnCompleted()
    {
        Console.WriteLine($"=====================================================================");
        Console.WriteLine($"=== Current Conditions Display has been successfully Unsubscribed ===");
        Console.WriteLine($"=====================================================================\n");
        _unsubscriber?.Dispose();
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("Error occured {0}", error);
    }

    public void OnNext(WeatherData value)
    {
        _temperature = value.Temperature;
        _humidity = value.Humidity;
        Display();
    }

    public override string? ToString()
    {
        return "CurrentConditions Display";
    }
}
