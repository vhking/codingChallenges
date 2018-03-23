using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class SumOfDigitsDigitalRootTest
    {
        private SumOfDigitsDigitalRoot num;

        [SetUp]
        public void SetUp()
        {
            num = new SumOfDigitsDigitalRoot();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(2, num.DigitalRootRF(493193));
        }
    }
}