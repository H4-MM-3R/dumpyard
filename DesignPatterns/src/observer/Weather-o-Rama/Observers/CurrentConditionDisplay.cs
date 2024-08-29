
using WeatherORama.Subjects;

namespace WeatherORama.Observers;

public class CurrentConditionDisplay : IObserver, IDisplayElement
{
    private double _temperature;
    private double _humidity;

    // remove readonly if you want to implement the remove / unregister observer
    private readonly ISubject _weatherData; 

    public CurrentConditionDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update(double temperature, double humidity, double pressure)
    {
       _temperature = temperature;
       _humidity = humidity;
       Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}°C, {_humidity}% humidity");
    }
}
