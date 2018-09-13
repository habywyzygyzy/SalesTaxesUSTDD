using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestyHednostkowe
{
    [TestClass]
    public class ArrayInitializerTest
    {
        private static Object[] arrayToInitialize;

        [TestInitialize]
        public void setUpProducts()
        {
            arrayToInitialize = Initializer.InitializeArray<Object>(10);
        }

        [TestMethod]
        public void inititializedArrayShouldNotContainAnyNull()
        {
            Object temp = null;
            for (int i = 0; i < arrayToInitialize.GetLength(0); i++)
            {
                temp = arrayToInitialize[i];
                Assert.IsNotNull(temp);
            }
        }
    }
}