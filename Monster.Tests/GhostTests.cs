using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monster.Monsters;

namespace Monster.Tests
{
    [TestClass]
    public class GhostTests
    {
        [TestMethod]
        public void CheckGhostNameCasper()
        {
            var monster = new Ghost();

            Assert.AreEqual("Casper", monster.Name);
        }

        [TestMethod]
        public void CheckGhostAttackSlime()
        {
            var monster = new Ghost();

            Assert.AreEqual("You've been slimed!", monster.Attack());
        }

        [TestMethod]
        public void CheckGhostDefendDisappear()
        {
            var monster = new Ghost();

            Assert.AreEqual("disappear", monster.Defend());
        }

        [TestMethod]
        public void CheckGhostScareBoo()
        {
            var monster = new Ghost();

            Assert.AreEqual("Boo!", monster.Scare());
        }

  

        [TestMethod]
        public void CheckGhostStringGhost()
        {
            var monster = new Ghost();

            Assert.AreEqual("I am a Ghost!", monster.ToString());
        }
    }
}
