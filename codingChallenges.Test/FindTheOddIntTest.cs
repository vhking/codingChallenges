using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class FindTheOddIntTest
    {
        private FindTheOddInt _find = new FindTheOddInt();

        [Test]
        public void FindTheOddInt_FindOddInt_ReturnTrue()
        {
            Assert.AreEqual(5, _find.Find(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            Assert.AreEqual(5, _find.Find( new[] { 20, 1, -1, -1, -1, 5, 5, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            Assert.AreEqual(5, _find.Find( new[] { 20, 1, -1, -1, -1, 5, 5, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20,20,20, 4, -1, -2, 5 }));
            Assert.AreEqual(0, _find.Find( new[] { -1,-1,-1,-1,0,0,0,0,0,1,1,1,1}));
           
        }
    }
}