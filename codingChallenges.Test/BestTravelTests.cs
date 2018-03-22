// using System;
// using System.Collections.Generic;
// using codingChallenges.CodeWars;
// using NUnit.Framework;

// namespace codingChallenges.Test
// {
//     [TestFixture]
//     public class BestTravelTests
//     {
//         private BestTravel _bt = new BestTravel();

//         [Test]
//         public void Test1()
//         {
//             Console.WriteLine("****** Basic Tests");
//             List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
//             int? n = _bt.chooseBestSum(163, 3, ts);
//             Assert.AreEqual(163, n);

//             ts = new List<int> { 50 };
//             n = _bt.chooseBestSum(163, 3, ts);
//             Assert.AreEqual(null, n);

//             ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
//             n = _bt.chooseBestSum(230, 3, ts);
//             Assert.AreEqual(228, n);
//         }
//     }
// }