using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class FindThePartyOutlinerTest
    {
        private FindThePartyOutliner _partyOutliner = new FindThePartyOutliner();

        [Test]
        public void Test1()
        {
            int[] exampleTest1 = { 2, 6, 8, -10, 3 };
            Assert.IsTrue(3 == _partyOutliner.Find(exampleTest1));
        }

        [Test]
        public void Test2()
        {
            int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Assert.IsTrue(206847684 == _partyOutliner.Find(exampleTest2));
        }

        [Test]
        public void Test3()
        {
            int[] exampleTest3 = { int.MaxValue, 0, 1 };
            Assert.IsTrue(0 == _partyOutliner.Find(exampleTest3));
        }
    }
}