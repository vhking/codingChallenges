using codingChallenges.CodeWars;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace codingChallenges.Test
{
    [TestFixture]
    public class SumOfTwoLowestPositiveIntegersTest
    {
	    [Test]
	    public void SumOfTwoLowestPositiveIntegers_Sum5And8_Expected13()
	    {
            SumOfTwoLowestPositiveIntegers sum = new SumOfTwoLowestPositiveIntegers();
            //int[] numbers = {5, 8, 12, 19, 22};
            //int[] numbers = {19, 5, 42, 2, 77};
            //long[] numbers = {10, 343445353, 3453445, 3453545353453};
            int[] numbers = {-1, 2, 10, 5, 100, -10, -100, 0};
		    //Assert.AreEqual(13, sum.sumTwoSmallestNumbers(numbers));
            //Assert.AreEqual(7, sum.sumTwoSmallestNumbers(numbers));
            //Assert.AreEqual(3453455, sum.sumTwoSmallestNumbers(numbers));	
            Assert.AreEqual(2, sum.sumTwoSmallestNumbers(numbers));	
	    }  
    }
}