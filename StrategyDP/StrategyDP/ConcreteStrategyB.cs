using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP
{
    class USPrice : IStrategy
    {
        public float getPrice(float price)
        {
            return (price * 0.07f) + price; 
        }
    }
}
