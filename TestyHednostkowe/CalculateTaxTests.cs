using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestyHednostkowe
{
    [TestClass]
    public class CalculateTaxTests
    {

        [TestMethod]
        public void calculateTaxShouldReturnProperValue()
        {
            float price = 100;
            float tax = 4.5F;
            float expected = (float)Math.Round(price * tax * 0.01F, 2);
            float actual = Calculator.calculateTax(price, tax);

            Assert.AreEqual(expected, actual, 0, "Policzone poprawnie");
        }

        [TestMethod]
        public void calculateBasicMarginShouldReturnProperValue()
        {
            float price = 100;
            float expected = (float)Math.Round(price + price * 0.1F, 2);
            float actual = price + Calculator.calculateBasicMargin(price);

            Assert.AreEqual(expected, actual, 0, "Policzone poprawnie");
        }

        [TestMethod]
        public void roundDownShouldReturnProperValue()
        {
            float price = 100.1292F;
            float expected = 100.12F;
            float actual = Calculator.roundDown(price);

            Assert.AreEqual(expected, actual, 0, "Policzone poprawnie");
        }
    }
}
