namespace _04_4_ASPCoreDI.Services.Impl
{
    public class MessengerService : IMessengerService
    {
        private readonly IWeatherService weatherService;

        public MessengerService(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }


        public string GetMessage()
        {
            var tomorrowWeather = weatherService.GetTomorrowWeather();
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
}
