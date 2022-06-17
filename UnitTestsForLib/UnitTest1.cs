using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryTest;

namespace UnitTestsForLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetQuantityForProductWithCorrectProductType()
        {
            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            
            int expected = 113805;
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProductWithIncorrectProductType()
        {
            int productType = 321;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            int expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProductWithCorrectCount()
        {
            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;

            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            int expected = 113805;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetQuantityForProductWithIncorrectCount()
        {
            int productType = 321;
            int materialType = 1;
            int count = 0;
            float width = 20;
            float length = 45;

            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            int expected = -1;

            Assert.AreEqual(expected, actual);
        }
    }
}
