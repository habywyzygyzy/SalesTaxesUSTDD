using System;
using System.Collections.Generic;

namespace SalesTaxesUSTDD
{
    public class ProductsImporter
    {
        public static Product[] importFromFile(String filePath)
        {
            int x;
            string line = null, title = null, category = null;
            int price = 0;
            List<Product> commodityData = new List<Product>();
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);

            while ((line = file.ReadLine()) != null)
            {
                title = line.Substring(0, line.IndexOf(','));
                x = line.IndexOf(',');
                line = line.Substring(line.IndexOf(',') + 1);

                category = line.Substring(0, line.IndexOf(','));
                line = line.Substring(line.IndexOf(',') + 1);

                price = int.Parse(line);
                commodityData.Add(new Product(title, category, price));
            }

            file.Close();
            return commodityData.ToArray();
        }
    }
}
