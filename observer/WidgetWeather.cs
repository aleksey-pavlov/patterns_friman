using System;

namespace Observer {

    public class WeatherWidgetData
    {
        public int Temperature;
        public int Pressure;
        public int Himidity;
    }

    public class WidgetWeather : Observer<WeatherWidgetData>
    {
        private string _name;

        public WidgetWeather(string name)
        {
            _name = name;
        }
        
        public override void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public override void OnNext(WeatherWidgetData value)
        {
            Console.WriteLine($"{_name} : Got new WeatherData temp={value.Temperature} himidity={value.Himidity} pressure={value.Pressure}");
        }
    }

}