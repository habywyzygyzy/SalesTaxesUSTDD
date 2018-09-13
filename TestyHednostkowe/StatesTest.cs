using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestyJednostkowe
{
    [TestClass]
    public class StatesTests
    {
        const int NUMBER_OF_STATES = 51;
        private static Stan[] statesArray = Initializer.InitializeArray<Stan>(NUMBER_OF_STATES);


        [TestInitialize]
        public void setUpStates()
        {
            String sciezka = @"..\..\Resources\States.txt";
            statesArray = TaxValuesImporter.TaxBuilder(sciezka);
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
                if (statesArray[i].Nazwa == "Kansas")
                {
                    stateFound = true;
                }
            }
            Assert.IsTrue(stateFound);
        }

        [TestMethod]
        public void allStatesShouldHaveSpecifiedTaxesForAllCategories()
        {
            float groceries, preparedFood, prescriptionDrug, nonPrescriptionDrug, clothing = -1;
            String name = null;
            for (int i = 0; i < statesArray.GetLength(0); i++)
            {
                name = statesArray[i].Nazwa;
                groceries = statesArray[i].spozywcze;
                preparedFood = statesArray[i].przygotowane;
                prescriptionDrug = statesArray[i].recepta;
                nonPrescriptionDrug = statesArray[i].lek;
                clothing = statesArray[i].odziez;

                Console.WriteLine(name);
                Assert.IsNotNull(name);
                Assert.IsTrue(groceries > -1);
                Assert.IsTrue(preparedFood > -1);
                Assert.IsTrue(prescriptionDrug > -1);
                Assert.IsTrue(nonPrescriptionDrug > -1);
                Assert.IsTrue(clothing > -1);

                groceries = preparedFood = prescriptionDrug = nonPrescriptionDrug = clothing = -1;
                name = null;
            }
        }
    }
}