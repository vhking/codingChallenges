using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class EqualSidesOfAnArrayTest
    {
        private EqualSidesOfAnArray _es = new EqualSidesOfAnArray();
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual(3, _es.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            Assert.AreEqual(1, _es.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            Assert.AreEqual(-1, _es.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            Assert.AreEqual(3, _es.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));
        }
    }
}