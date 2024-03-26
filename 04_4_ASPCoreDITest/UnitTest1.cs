using _04_4_ASPCoreDI.Services;
using _04_4_ASPCoreDI.Services.Impl;
using Moq;

namespace _04_4_ASPCoreDITest
{
    [TestClass]
    public class UnitTest1
    {
        public class SunnyWeatherService : IWeatherService
        {
            public string GetTomorrowWeather()
            {
                return "����";
            }
        }

        [TestMethod]
        public void GetMessage_����e�X�g()
        {
            // Moq���g��Ȃ��e�X�g���@
            var sunny = new SunnyWeatherService();
            var messenger = new MessengerService(sunny);
            var msg = messenger.GetMessage();
            Assert.AreEqual("�����͗ǂ��V�C�ł��B�撣��܂��傤", msg);
        }

        [TestMethod]
        public void GetMessage_Moq����e�X�g()
        {
            // Moq�̏Љ� 
            var sunnyMoq = new Mock<IWeatherService>();
            sunnyMoq.Setup(x => x.GetTomorrowWeather()).Returns("����");
            var messenger = new MessengerService(sunnyMoq.Object);
            var msg = messenger.GetMessage();
            Assert.AreEqual("�����͗ǂ��V�C�ł��B�撣��܂��傤", msg);
        }

        [TestMethod]
        public void GetMessage_Moq�܂�e�X�g()
        {
            // Moq�̏Љ� 
            var cloudyMoq = new Mock<IWeatherService>();
            cloudyMoq.Setup(x => x.GetTomorrowWeather()).Returns("�܂�");
            var messenger = new MessengerService(cloudyMoq.Object);
            var msg = messenger.GetMessage();
            Assert.AreEqual("�����͓܂�̂悤�ł��B�C�����āI", msg);
        }

        [TestMethod]
        public void GetMessage_Moq�J�e�X�g()
        {
            // Moq�̏Љ� 
            var rainyMoq = new Mock<IWeatherService>();
            rainyMoq.Setup(x => x.GetTomorrowWeather()).Returns("�J");
            var messenger = new MessengerService(rainyMoq.Object);
            var msg = messenger.GetMessage();
            Assert.AreEqual("�����͉J�݂����ł��B�P��Y��Ȃ��悤�ɁI", msg);
        }
    }
}