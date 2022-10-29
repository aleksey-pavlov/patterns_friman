using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Observable<WeatherWidgetData> weather = new WeatherData();

            Observer<WeatherWidgetData> widget1 = new WidgetWeather("WIDGET_1");

            Observer<WeatherWidgetData> widget2 = new WidgetWeather("WIDGET_2");


            widget1.Subscribe(weather);
            widget2.Subscribe(weather);

            weather.Notify(new WeatherWidgetData { Himidity = 2, Pressure = 4, Temperature = 5 });


            widget2.OnCompleted();

            weather.Notify(new WeatherWidgetData { Himidity = 4, Pressure = 5, Temperature = 6 });

        }
    }
}
