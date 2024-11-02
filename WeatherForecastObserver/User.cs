namespace WeatherObserver
{
    internal class User : IWeatherForecastObserver
    {
        private readonly string _name;
        private readonly string _email;
        private readonly string _phone;

        public User(string name, string email, string phone)
        {
            _email = email;
            _name = name;
            _phone = phone;
        }

        public void UpdateWeatherReport(string city, double temperature)
        {
            Console.WriteLine($"Hello {_name}!\n{city} Weather Alert: Current temperature is {temperature} °C - {DateTime.Now}.\nA \"suffocating level\" warning has been issued for your area due to high heat, humidity, or poor air quality. Limit outdoor activities, stay hydrated, and remain indoors if possible.\r\n\r\nStay safe!\r\n\r\n");
        }
    }
}
