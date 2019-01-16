using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP
{
    class CAPrice : IStrategy
    {
        public float getPrice(float price)
        {
            float firstTaxResult = (price * 0.05f) + price;
            return (firstTaxResult * 0.09975f) + price;
        }
    }
}
