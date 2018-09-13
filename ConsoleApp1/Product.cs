using System;

namespace SalesTaxesUSTDD
{
    public class Product
    {
        public String title { get; }
        public String category { get; }
        public float price { get; }

        public Product(String title, String category, float price)
        {
            this.title = title;
            this.category = category;
            this.price = price;
        }
    }
}
