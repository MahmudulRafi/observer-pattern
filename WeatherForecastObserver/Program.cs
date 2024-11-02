using WeatherObserver;

var dhakaWeatherStation = new WeatherForecastStation("Dhaka", 35.0);
var chittagongWeatherStation = new WeatherForecastStation("Chittagong", 38.0);

dhakaWeatherStation.RegisterObserver(new User("Mr. Abc", "abc@gmail.com", "0190000000"));
dhakaWeatherStation.RegisterObserver(new User("Mr. Xyz", "xyz@gmail.com", "0180000000"));

chittagongWeatherStation.RegisterObserver(new User("Mr. Efd", "efd@gmail.com", "0170000000"));

dhakaWeatherStation.Temperature = 32.33;
dhakaWeatherStation.Temperature = 37.33;

chittagongWeatherStation.Temperature = 42.2;