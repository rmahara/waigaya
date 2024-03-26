namespace _04_3_DIConsole2
{
    public class WeatherService 
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
