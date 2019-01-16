using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP
{
    class Context
    {
        IStrategy _strategyA = new CAPrice();
        IStrategy _strategyB = new USPrice();

        public Context()
        {

        }

        public float getTotalPrice(float value, string country)
        {
            if(country == "CA")
            {
                return _strategyA.getPrice(value);
            }
            else
            {
                return _strategyB.getPrice(value);
            }
        }
    }
}
