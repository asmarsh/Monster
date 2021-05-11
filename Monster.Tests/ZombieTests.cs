using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monster.Monsters;

namespace Monster.Tests
{
    [TestClass]
    public class ZombieTests
    {
        [TestMethod]
        public void CheckZombieNameWalker()
        {
            var monster = new Zombie();

            Assert.AreEqual("Walker", monster.Name);
        }

        [TestMethod]
        public void CheckZombieAttackBitten()
        {
            var monster = new Zombie();

            Assert.AreEqual("You have been bitten!", monster.Attack());
        }

        [TestMethod]
        public void CheckZombieDefendEmpty()
        {
            var monster = new Zombie();

            Assert.AreEqual(string.Empty, monster.Defend());
        }

        [TestMethod]
        public void CheckZombieScareScream()
        {
            var monster = new Zombie();

            Assert.AreEqual("Scream!", monster.Scare());
        }


        [TestMethod]
        public void CheckZombieStringZombie()
        {
            var monster = new Zombie();

            Assert.AreEqual("I am a Zombie!", monster.ToString());
        }
    }
}
