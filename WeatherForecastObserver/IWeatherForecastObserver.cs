namespace WeatherObserver
{
    internal interface IWeatherForecastObserver
    {
        void UpdateWeatherReport(string city, double temperature);
    }
}