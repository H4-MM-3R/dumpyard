using WeatherORama.Subjects;
using WeatherORama.Observers;

namespace WeatherORama;

public class Program
{
    static void Main(string[] args)
    {
        WeatherData subject = new WeatherData();

        CurrentConditionDisplay observer1 = new CurrentConditionDisplay(subject);
        ForecastDisplay observer2 = new ForecastDisplay(subject);
        StatisticsDisplay observer3 = new StatisticsDisplay(subject);
        HeatIndexDisplay observer4 = new HeatIndexDisplay(subject);

            subject.SetMeasurements(80, 65, 30.4d);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            subject.SetMeasurements(82, 70, 29.2d);
            subject.RemoveObserver(observer3);

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            subject.SetMeasurements(78, 90, 29.2d);
    }
}
