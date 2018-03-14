using System;
using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class RevrotTests
    {
        private ReverseOrRotate _rr = new ReverseOrRotate();
        private void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        

        [Test]
        public void test1()
        {
            Console.WriteLine("Testing RevRot");
            testing(_rr.RevRot("1234", 0), "");
            testing(_rr.RevRot("", 0), "");
            testing(_rr.RevRot("1234", 5), "");
            String s = "733049910872815764";
            testing(_rr.RevRot(s, 5), "330479108928157");
            testing(_rr.RevRot("123456987654", 6), "234561876549");
            testing(_rr.RevRot("123456987653", 6), "234561356789");
            testing(_rr.RevRot("66443875", 4), "44668753");
            testing(_rr.RevRot("66443875", 8), "64438756");
            testing(_rr.RevRot("664438769", 8), "67834466");
            testing(_rr.RevRot("123456779", 8), "23456771");
            testing(_rr.RevRot("563000655734469485", 4), "0365065073456944");

        }

        //  Examples:
        // revrot("123456987654", 6) --> "234561876549"
        // revrot("123456987653", 6) --> "234561356789"
        // revrot("66443875", 4) --> "44668753"
        // revrot("66443875", 8) --> "64438756"
        // revrot("664438769", 8) --> "67834466"
        // revrot("123456779", 8) --> "23456771"     
        // revrot("5630 0065 5734 4694 85", 4) --> "0365 0650 7345 6944"
    }
}