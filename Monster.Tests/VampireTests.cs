using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monster.Monsters;

namespace Monster.Tests
{
    [TestClass]
    public class VampireTests
    {
        [TestMethod]
        public void CheckVampireNameBlade()
        {
            var monster = new Vampire();

            Assert.AreEqual("Blade", monster.Name);
        }

        [TestMethod]
        public void CheckVampireAttackBitten()
        {
            var monster = new Vampire();

            Assert.AreEqual("You have been bitten!", monster.Attack());
        }

        [TestMethod]
        public void CheckVampireDefendBat()
        {
            var monster = new Vampire();

            Assert.AreEqual("Turn into a bat and fly away...", monster.Defend());
        }

        [TestMethod]
        public void CheckVampireScareVampire()
        {
            var monster = new Vampire();

            Assert.AreEqual("I am a vampire!", monster.Scare());
        }

        [TestMethod]
        public void CheckVampireSecondaryCompel()
        {
            var monster = new Vampire();

            Assert.AreEqual("You have been compelled to do my bidding!", monster.SecondaryAttack());
        }

        [TestMethod]
        public void CheckVampireStringVampire()
        {
            var monster = new Vampire();

            Assert.AreEqual("I am a Vampire!", monster.ToString());
        }
    }
}
