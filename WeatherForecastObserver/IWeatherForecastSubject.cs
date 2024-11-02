namespace WeatherObserver
{
    internal interface IWeatherForecastSubject
    {
        double Temperature { get; set; }
        void RegisterObserver(IWeatherForecastObserver observer);
        void RemoveObserver(IWeatherForecastObserver observer);
        void NotifyObservers();
    }
}
