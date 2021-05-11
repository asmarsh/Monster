using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monster.Monsters;

namespace Monster.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var monster = new Werewolf();

            Assert.AreEqual("Mason", monster.Name);
        }
    }
}
