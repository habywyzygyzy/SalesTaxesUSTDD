﻿using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestyJednostkowe
{
    [TestClass]
    public class ProductTests
    {
        private static Product[] productsArray = Initializer.InitializeArray<Product>(19);


        [TestInitialize]
        public void setUpProducts()
        {
            String sciezka = @"..\..\..\SaleTaxUS\Resources\product_list.csv";
            productsArray = ProductsImporter.importFromFile(sciezka);
        }

        [TestMethod]
        public void productsArrayShouldContainMoreThanZeroElements()
        {
            Assert.IsTrue(productsArray.GetLength(0) > 0);
        }

        [TestMethod]
        public void apapShouldBeContainedInProductsArray()
        {
            Boolean productFound = false;
            for (int i = 0; i < productsArray.GetLength(0); i++)
            {
                if (productsArray[i].title == "apap")
                {
                    productFound = true;
                }
            }
            Assert.IsTrue(productFound);
        }

        [TestMethod]
        public void allProductsShouldHaveSpecifiedPriceTitleAndCategory()
        {
            float price = -1;
            String category = null;
            String title = null;
            for (int i = 0; i < productsArray.GetLength(0); i++)
            {
                price = productsArray[i].price;
                category = productsArray[i].category;
                title = productsArray[i].title;
                Assert.IsTrue(price > -1);
                Assert.IsNotNull(category);
                Assert.IsNotNull(title);
                price = -1;
                category = null;
                title = null;
            }
        }
    }
}