using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public class MinusStrategy : ICalcStrategy
    {
        public float Calc(float value1, float value2)
        {
            return value1 - value2;
        }
    }
}
