using codingChallenges.CodeWars;
using NUnit.Framework;

namespace Tests
{
    public class BuildTowerTest
    {
        [Test]
        public void TowerBulder_BuildTower_ReturnString()
        {
            Assert.AreEqual(string.Join(",", new [] { "*" }), string.Join(",", BuildTower.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new [] { " * ", "***" }), string.Join(",", BuildTower.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new [] { "  *  ", " *** ", "*****" }), string.Join(",", BuildTower.TowerBuilder(3)));
        }
    }
}