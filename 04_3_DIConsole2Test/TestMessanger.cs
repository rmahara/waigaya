using _04_3_DIConsole2;
using Moq;

namespace _04_2_DIConsoleTest
{
    [TestClass]
    public class TestMessanger
    {
        public class SunnyWeatherService : IWeatherService
        {
            public string GetTomorrowWeather()
            {
                return "晴れ";
            }
        }

        [TestMethod]
        public void GetMessage_晴れテスト()
        {
            // Moqを使わないテスト方法
            var sunny = new SunnyWeatherService();
            var messenger = new Messenger(sunny);
            var msg = messenger.GetMessage();
            Assert.AreEqual("明日は良い天気です。頑張りましょう", msg);
        }

        [TestMethod]
        public void GetMessage_Moq晴れテスト()
        {
            // Moqの紹介 
            var sunnyMoq = new Mock<IWeatherService>();
            sunnyMoq.Setup(x => x.GetTomorrowWeather()).Returns("晴れ");
            var messenger = new Messenger(sunnyMoq.Object);
            var msg = messenger.GetMessage();
            Assert.AreEqual("明日は良い天気です。頑張りましょう", msg);
        }

        [TestMethod]
        public void GetMessage_Moq曇りテスト()
        {
            // Moqの紹介 
            var cloudyMoq = new Mock<IWeatherService>();
            cloudyMoq.Setup(x => x.GetTomorrowWeather()).Returns("曇り");
            var messenger = new Messenger(cloudyMoq.Object);
            var msg = messenger.GetMessage();
            Assert.AreEqual("明日は曇りのようです。気をつけて！", msg);
        }

        [TestMethod]
        public void GetMessage_Moq雨テスト()
        {
            // Moqの紹介 
            var rainyMoq = new Mock<IWeatherService>();
            rainyMoq.Setup(x => x.GetTomorrowWeather()).Returns("雨");
            var messenger = new Messenger(rainyMoq.Object);
            var msg = messenger.GetMessage();
            Assert.AreEqual("明日は雨みたいです。傘を忘れないように！", msg);
        }
    }
}