namespace _04_3_DIConsole2
{
    /// <summary>
    /// メッセージを担当するクラス
    /// </summary>
    public class Messenger
    {
        private readonly IWeatherService weatherService;
        public Messenger(IWeatherService weatherService) 
        {
            this.weatherService = weatherService;
        }

        public string GetMessage()
        {
            var service = new WeatherService();
            var tomorrowWeather = service.GetTomorrowWeather();
            switch (tomorrowWeather)
            {
                case "晴れ":
                    return "明日は良い天気です。頑張りましょう";
                case "雨":
                    return "明日は雨みたいです。傘を忘れないように！";
                case "曇り":
                    return "明日は曇りのようです。気をつけて！";
                default:
                    throw new Exception("想定外エラー");
            }
        }
    }

    public interface IWeatherService 
    {
    
    }
}
