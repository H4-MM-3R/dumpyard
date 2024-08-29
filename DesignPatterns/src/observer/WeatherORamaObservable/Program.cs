using WeatherORamaObservable.Observers;
using WeatherORamaObservable.Subjects;

namespace WeatherORamaObservable;

public class Program
{
    static void Main(string[] args)
    {
        WeatherData subject = new WeatherData();

        CurrentConditionsDisplay observer1 = new CurrentConditionsDisplay(subject);
        ForecastDisplay observer2 = new ForecastDisplay(subject);
        StatisticsDisplay observer3 = new StatisticsDisplay(subject);
        HeatIndexDisplay observer4 = new HeatIndexDisplay(subject);

        subject.SetMeasurements(80, 65, 30.4d);

        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();

        observer3.OnCompleted();
        subject.SetMeasurements(82, 70, 29.2d);

        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();

        subject.Subscribe(observer3);
        subject.SetMeasurements(78, 90, 29.2d);
    }
}
