using WeatherORamaObservable.Subjects;

namespace WeatherORamaObservable.Observers;

public class HeatIndexDisplay : IObserver<WeatherData>, IDisplayElement
{
    private double _heatIndex;
    private readonly IDisposable? _unsubscriber;

    public HeatIndexDisplay(IObservable<WeatherData> weatherData)
    {
        _unsubscriber = weatherData?.Subscribe(this);
    }

    public void Display()
    {
        Console.WriteLine($"Heat index: {_heatIndex}");
    }

    public void OnCompleted()
    {
        Console.WriteLine($"=============================================================");
        Console.WriteLine($"=== Heat Index Display has been successfully Unsubscribed ===");
        Console.WriteLine($"=============================================================\n");
        _unsubscriber?.Dispose();
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("Error occured {0}", error);
    }

    public void OnNext(WeatherData value)
    {
        _heatIndex = CalculateHeatIndex(value.Temperature, value.Humidity);
        Display();
    }

    private double CalculateHeatIndex(double temp, double relativeHumidity)
    {
        // Base Constant
        double heatIndex = 16.923;

        // Linear effects
        heatIndex += 0.185212 * temp + 5.37941 * relativeHumidity;

        // Temperature-humidity interaction
        heatIndex -= 0.100254 * temp * relativeHumidity;

        // Quadratic effects
        heatIndex += 0.00941695 * Math.Pow(temp, 2) + 0.00728898 * Math.Pow(relativeHumidity, 2);

        // Cubic effects
        heatIndex -= 0.000038646 * Math.Pow(temp, 3);
        heatIndex +=
            0.000345372 * Math.Pow(temp, 2) * relativeHumidity
            - 0.000814971 * temp * Math.Pow(relativeHumidity, 2);
        heatIndex += 0.0000291583 * Math.Pow(relativeHumidity, 3);

        // Quartic effects
        heatIndex += 0.0000102102 * Math.Pow(temp, 2) * Math.Pow(relativeHumidity, 2);
        heatIndex += 0.00000142721 * Math.Pow(temp, 3) * relativeHumidity;
        heatIndex += 0.000000197483 * temp * Math.Pow(relativeHumidity, 3);

        // Quintic effects
        heatIndex -= 0.0000000218429 * Math.Pow(temp, 3) * Math.Pow(relativeHumidity, 2);
        heatIndex += 0.000000000843296 * Math.Pow(temp, 2) * Math.Pow(relativeHumidity, 3);

        // Sextic effect
        heatIndex -= 0.0000000000481975 * Math.Pow(temp, 3) * Math.Pow(relativeHumidity, 3);

        return heatIndex;
    }

    public override string? ToString()
    {
        return "Heat Index Display";
    }
}
