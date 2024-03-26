namespace _04_4_ASPCoreDI.Services.Impl
{
    public class WeatherService : IWeatherService
    {
        public string GetTomorrowWeather()
        {
            int weatherKind = 1;

            string tomorrowWeather = weatherKind switch
            {
                1 => "晴れ",
                2 => "曇り",
                3 => "雨",
                _ => throw new Exception("天気情報を取得できませんでした。")
            };

            return tomorrowWeather;
        }
    }
}
