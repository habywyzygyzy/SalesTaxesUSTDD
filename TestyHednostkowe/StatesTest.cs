using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxesUSTDD;

namespace TestyJednostkowe
{
    [TestClass]
    public class StatesTests
    {
        const int NUMBER_OF_STATES = 51;
        private static State[] statesArray = Initializer.InitializeArray<State>(NUMBER_OF_STATES);


        [TestInitialize]
        public void setUpStates()
        {
            String path = @"..\..\..\ConsoleApp1\Resources\States.txt";
            statesArray = TaxValuesImporter.TaxBuilder(path);
        }

        [TestMethod]
        public void statesArrayShouldContainMoreThanZeroElements()
        {
            Assert.IsTrue(statesArray.GetLength(0) > 0);
        }

        [TestMethod]
        public void kansasShouldBeContainedInStatesArray()
        {
            Boolean stateFound = false;
            for (int i = 0; i < statesArray.GetLength(0); i++)
            {
                if (statesArray[i].name == "Kansas")
                {
                    stateFound = true;
                }
            }
            Assert.IsTrue(stateFound);
        }

        [TestMethod]
        public void allStatesShouldHaveSpecifiedTaxesForAllCategories()
        {
            float groceries, preparedFood, prescriptionDrug, nonPrescriptionDrug, clothing, intangibles = -1;
            String name = null;
            for (int i = 0; i < statesArray.GetLength(0); i++)
            {
                name = statesArray[i].name;
                groceries = statesArray[i].groceries;
                preparedFood = statesArray[i].preparedFood;
                prescriptionDrug = statesArray[i].prescriptionDrug;
                nonPrescriptionDrug = statesArray[i].nonPrescriptionDrug;
                clothing = statesArray[i].clothing;
                intangibles = statesArray[i].intangibles;

                Assert.IsNotNull(name);
                Assert.IsTrue(groceries > -1);
                Assert.IsTrue(preparedFood > -1);
                Assert.IsTrue(prescriptionDrug > -1);
                Assert.IsTrue(nonPrescriptionDrug > -1);
                Assert.IsTrue(clothing > -1);
                Assert.IsTrue(intangibles > -1);

                groceries = preparedFood = prescriptionDrug = nonPrescriptionDrug = clothing = intangibles = -1;
                name = null;
            }
        }
    }
}