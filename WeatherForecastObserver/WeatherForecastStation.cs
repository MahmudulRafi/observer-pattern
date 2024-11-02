namespace WeatherObserver
{
    internal class WeatherForecastStation : IWeatherForecastSubject
    {
        private readonly string _cityName;
        private double _currentTemperature;
        private readonly double _suffocatingTemperature;
        private readonly IList<IWeatherForecastObserver> _observers;

        public double Temperature
        {
            get
            {
                return _currentTemperature;
            }
            set
            {
                _currentTemperature = value;   
                
                NotifyObservers();  
            }
        }

        public WeatherForecastStation(string cityName, double suffocatingTemperature)
        {
            _cityName = cityName;
            _suffocatingTemperature = suffocatingTemperature;
            _observers = [];
        }

        public void RegisterObserver(IWeatherForecastObserver observer)
        {
            if (observer is not null && !_observers.Contains(observer))
                _observers.Add(observer);
        }

        public void RemoveObserver(IWeatherForecastObserver observer)
        {
            if (observer is not null)
                _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            if (_currentTemperature > _suffocatingTemperature)
            {
                foreach (var observer in _observers)
                {
                    observer.UpdateWeatherReport(_cityName, _currentTemperature);
                }
            }
        }
    }
}
