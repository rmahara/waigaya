using _04_2_DIConsole;

namespace _04_2_DIConsoleTest
{
    [TestClass]
    public class TestMessanger
    {
        [TestMethod]
        public void GetMessage_����e�X�g()
        {
            var messenger = new Messenger();
            var msg = messenger.GetMessage();
            Assert.AreEqual("�����͗ǂ��V�C�ł��B�撣��܂��傤", msg);
        }

        [TestMethod]
        public void GetMessage_�܂�e�X�g()
        {
            var messenger = new Messenger();
            var msg = messenger.GetMessage();
            Assert.AreEqual("�����͓܂�̂悤�ł��B�C�����āI", msg);
        }

        [TestMethod]
        public void GetMessage_�J�e�X�g()
        {
            var messenger = new Messenger();
            var msg = messenger.GetMessage();
            Assert.AreEqual("�����͉J�݂����ł��B�P��Y��Ȃ��悤�ɁI", msg);
        }
    }
}