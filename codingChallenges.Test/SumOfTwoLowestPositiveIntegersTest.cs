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
            int[] numbers = {5, 8, 12, 19, 22};
            //int[] numbers = {12, 22, 5, 19 ,8};
		    Assert.AreEqual(13, sum.sumTwoSmallestNumbers(numbers));		
	    }  
    }
}