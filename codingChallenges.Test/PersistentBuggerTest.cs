using System;
using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
    {


    [TestFixture]
    public class PersistentBuggerTest 
    {
        private PersistentBugger pb = new PersistentBugger();
        [Test]
        public void Test1() 
        {
            Console.WriteLine("****** Basic Tests");    
            Assert.AreEqual(3, pb.Persistence(39));
            Assert.AreEqual(0, pb.Persistence(4));
            Assert.AreEqual(2, pb.Persistence(25));
            Assert.AreEqual(4, pb.Persistence(999));
        }
    }
}