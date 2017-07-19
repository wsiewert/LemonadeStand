using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        List<string> weatherType = new List<string>() { "rainy", "sunny", "cloudy" };
        int forecastTemperature;
        string forecastWeather;
        int actualTemperature;
        string actualWeather;
        int temperatureRangeMin = 50;
        int temperatureRangeMax = 95;
        int actualTemperatureFluctuation = 4;

        public List<string> WeatherType
        {
            get { return weatherType; }
        }

        public int TemperatureRangeMin
        {
            get { return temperatureRangeMin; }
        }

        public int TemperatureRangeMax
        {
            get { return temperatureRangeMax; }
        }

        public string ActualWeather
        {
            get { return actualWeather; }
        }

        public int ActualTemperature
        {
            get { return actualTemperature; }
        }

        public Weather(Random random)
        {
            GenerateForecast(random);
            GenerateActualWeather(random);
        }
        
        public int GetForecastTemperature()
        {
            return forecastTemperature;
        }

        public string GetForecastWeather()
        {
            return forecastWeather;
        }

        public int GetActualTemperature()
        {
            return actualTemperature;
        }

        public string GetActualWeather()
        {
            return actualWeather;
        }

        public void GenerateForecast(Random random)
        {
            int weatherTypeIndex = random.Next(0, weatherType.Count);
            forecastTemperature = random.Next(temperatureRangeMin,temperatureRangeMax);
            forecastWeather = weatherType[weatherTypeIndex];
        }

        public void GenerateActualWeather(Random random)
        {
            int weatherTypeIndex = random.Next(0, weatherType.Count);
            int forecastTemperatureHigh = forecastTemperature + actualTemperatureFluctuation;
            int forecastTemperatureLow = forecastTemperature - actualTemperatureFluctuation;
            actualTemperature = random.Next(forecastTemperatureLow, forecastTemperatureHigh);
            actualWeather = weatherType[weatherTypeIndex];
        }
    }
}
