using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class DigPowTests
    {
        private PlayingWithDigits _play = new PlayingWithDigits();

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, _play.digPower(89, 1));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(-1, _play.digPower(92, 1));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(51, _play.digPower(46288, 3));
        }
    }
}