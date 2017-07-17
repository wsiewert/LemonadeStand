using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        int forecastTemperature;
        string forecastWeather;
        int actualTemperature;
        string actualWeather;
        int temperatureRangeMin = 50;
        int temperatureRangeMax = 95;

        public int TemperatureRangeMin
        {
            get { return temperatureRangeMin; }
        }

        public int TemperatureRangeMax
        {
            get { return temperatureRangeMax; }
        }

        public Weather(List<string> weatherType, Random random)
        {
            GenerateForecast(weatherType,random);
            GenerateActualWeather(weatherType,random);
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

        public void GenerateForecast(List<string> weatherType, Random random)
        {
            int weatherTypeIndex = random.Next(0, weatherType.Count);
            forecastTemperature = random.Next(temperatureRangeMin,temperatureRangeMax);
            forecastWeather = weatherType[weatherTypeIndex];
        }

        public void GenerateActualWeather(List<string> weatherType, Random random)
        {
            int weatherTypeIndex = random.Next(0, weatherType.Count);
            actualTemperature = random.Next(temperatureRangeMin, temperatureRangeMax);
            actualWeather = weatherType[weatherTypeIndex];
        }
    }
}
