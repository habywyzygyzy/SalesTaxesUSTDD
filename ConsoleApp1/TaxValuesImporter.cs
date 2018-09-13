using System;
using System.IO;

namespace SalesTaxesUSTDD
{
    public class TaxValuesImporter
    {
        const int NUMBER_OF_STATES = 51;

        public static State[] TaxBuilder(String path)
        {
            State[] StatesTaxes = Initializer.InitializeArray<State>(NUMBER_OF_STATES);
            int i = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (i != NUMBER_OF_STATES)
                {
                    StatesTaxes[i].name = sr.ReadLine();
                    StatesTaxes[i].groceries = float.Parse(sr.ReadLine());
                    StatesTaxes[i].preparedFood = float.Parse(sr.ReadLine());
                    StatesTaxes[i].prescriptionDrug = float.Parse(sr.ReadLine());
                    StatesTaxes[i].nonPrescriptionDrug = float.Parse(sr.ReadLine());
                    StatesTaxes[i].clothing = float.Parse(sr.ReadLine());
                    StatesTaxes[i].intangibles = float.Parse(sr.ReadLine());
                    i++;
                }

            }
            return StatesTaxes;
        }
    }
}
