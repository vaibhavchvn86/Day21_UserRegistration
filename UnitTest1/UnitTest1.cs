using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAppWithCore;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        UserRegister check = new UserRegister();
        private readonly UserRegister User;
        public UnitTest1()
        {
            User = new UserRegister();
        }
        ///UC1
        [TestMethod]
        public void FirstName()
        {
            var result = User.FirstName("Vaibhav");
            Assert.AreEqual(true, result);
        }
        ///UC2
        [TestMethod]
        public void LastName()
        {
            var result = User.LastName("Chavan");
            Assert.AreEqual(true, result);
        }
        ///UC3,UC9
        [TestMethod]
        public void Email()
        {
            var result = User.email("Vaib@abc.com");
            Assert.AreEqual(true, result);
        }
        ///UC4
        [TestMethod]
        public void Mobile()
        {
            var result = User.Mobnum("91 8090765432");
            Assert.AreEqual(true, result);
        }
        ///UC5, UC6, UC7, UC8
        [TestMethod]
        public void Password()
        {
            var result = User.Password("Av@8bbb9");
            Assert.AreEqual(true, result);
        }
    }
}
