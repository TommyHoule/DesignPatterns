using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDP
{
    interface IStrategy
    {
        float getPrice(float price);
    }
}
