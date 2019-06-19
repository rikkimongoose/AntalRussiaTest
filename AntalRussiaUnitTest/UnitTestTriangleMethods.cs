using AntalRussiaTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AntalRussiaUnitTest
{
    [TestClass]
    public class UnitTestTriangleMethods
    {

        private readonly ITriangleMethods triangleMethods = new TriangleMethods();

        [TestMethod]
        public void TestZeroSide()
        {
            double zero = 0d,
                   b = 1d,
                   c = 1d;

            double area1 = triangleMethods.area(zero, b, c);
            double area2 = triangleMethods.area(b, zero, c);
            double area3 = triangleMethods.area(b, c, zero);

            Assert.AreEqual(area1, 0);
            Assert.AreEqual(area2, 0);
            Assert.AreEqual(area3, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
    "a can't be negative.")]
        public void TestNegativeRadius()
        {
            double neg = -1d,
                   b = 1d,
                   c = 1d;

            double area = triangleMethods.area(neg, b, c);
        }


        [TestMethod]
        public void TestPositiveRadius()
        {
            double expectedArea = 0.43301d;
            double a = 1d,
                   b = 1d,
                   c = 1d;

            double area = triangleMethods.area(a, b, c);
            double areaRound = Math.Round(area, 5);
            Assert.AreEqual(areaRound, expectedArea);
        }
    }
}
