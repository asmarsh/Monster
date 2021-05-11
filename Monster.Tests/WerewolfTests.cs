using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monster.Monsters;

namespace Monster.Tests
{
    [TestClass]
    public class WerewolfTests
    {
        [TestMethod]
        public void CheckWerewolfNameMason()
        {
            var monster = new Werewolf();

            Assert.AreEqual("Mason", monster.Name);
        }

        [TestMethod]
        public void CheckWerewolfAttackBite()
        {
            var monster = new Werewolf();

            Assert.AreEqual("Bite!", monster.Attack());
        }

        [TestMethod]
        public void CheckWerewolfDefendRun()
        {
            var monster = new Werewolf();

            Assert.AreEqual("Run away!", monster.Defend());
        }

        [TestMethod]
        public void CheckWerewolfScareGrowl()
        {
            var monster = new Werewolf();

            Assert.AreEqual("Growl!", monster.Scare());
        }

        [TestMethod]
        public void CheckWerewolfSecondaryClaw()
        {
            var monster = new Werewolf();

            Assert.AreEqual("Claw!", monster.SecondaryAttack());
        }

        [TestMethod]
        public void CheckWerewolfStringLycanthrope()
        {
            var monster = new Werewolf();

            Assert.AreEqual("I am a Lycanthrope!", monster.ToString());
        }
    }
}
