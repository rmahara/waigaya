using _04_2_DIConsole;

namespace _04_2_DIConsoleTest
{
    [TestClass]
    public class TestMessanger
    {
        [TestMethod]
        public void GetMessage_晴れテスト()
        {
            var messenger = new Messenger();
            var msg = messenger.GetMessage();
            Assert.AreEqual("明日は良い天気です。頑張りましょう", msg);
        }

        [TestMethod]
        public void GetMessage_曇りテスト()
        {
            var messenger = new Messenger();
            var msg = messenger.GetMessage();
            Assert.AreEqual("明日は曇りのようです。気をつけて！", msg);
        }

        [TestMethod]
        public void GetMessage_雨テスト()
        {
            var messenger = new Messenger();
            var msg = messenger.GetMessage();
            Assert.AreEqual("明日は雨みたいです。傘を忘れないように！", msg);
        }
    }
}