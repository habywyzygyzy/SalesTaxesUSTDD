using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxesUSTDD
{
    public static class Calculator
    {
        public const float BASIC_MARGIN = 0.1F;
        public const float PERCENT = 0.01F;

        public static float calculateTax(float price, float tax)
        {
            float calculatedTax = price * tax * PERCENT;
            calculatedTax = roundDown(calculatedTax);
            return calculatedTax;
        }
        public static float calculateBasicMargin(float price)
        {
            float priceWithMargin = price * BASIC_MARGIN;
            priceWithMargin = roundDown(priceWithMargin);
            return priceWithMargin;
        }
        public static float roundDown(float valueToRound)
        {
            valueToRound = (float)Math.Floor(valueToRound * 100) / 100;
            return valueToRound;
        }
    }
}
