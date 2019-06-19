using AntalRussiaTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AntalRussiaUnitTest
{
    [TestClass]
    public class UnitTestCircleMethods
    {

        private readonly ICircleMethods circleMethods = new CircleMethods();

        [TestMethod]
        public void TestZeroRadius()
        {
            double radius = 0d;

            double area = circleMethods.area(radius);
            Assert.AreEqual(area, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
    "radius can't be negative.")]
        public void TestNegativeRadius()
        {
            double radius = -1d;

            double area = circleMethods.area(radius);
        }


        [TestMethod]
        public void TestPositiveRadius()
        {
            double expectedArea = 12.56637d;
            double radius = 2d;

            double area = circleMethods.area(radius);
            double areaRound = Math.Round(area, 5);
            Assert.AreEqual(areaRound, expectedArea);
        }
    }
}
