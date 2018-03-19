using System;
using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class WeightForWeightTest
    {
        private WeightForWeight _ww = new WeightForWeight();
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual("2000 103 123 4444 99", _ww.orderWeight("103 123 4444 99 2000"));
            Assert.AreEqual("11 11 2000 10003 22 123 1234000 44444444 9999", _ww.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }
    }
}