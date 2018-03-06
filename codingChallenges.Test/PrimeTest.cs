namespace codingChallenges.Test
{
    using codingChallenges.CodeWars;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class SolutionTest
    {
        private Prime p = new Prime();
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(-5347).Returns(true);
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(5347).Returns(true);
            }
        }

        [Test, TestCaseSource("sampleTestCases")]
        public bool SampleTest(int n) => p.IsPrime(n);
    }
}