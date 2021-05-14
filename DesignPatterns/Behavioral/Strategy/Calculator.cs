using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public class Calculator
    {
        public ICalcStrategy Strategy { get; set; }

        public float Calculate(Func<float, float, float> func, float val1, float val2)
        {
            return func(val1, val2);
        }


        public float Calculate(float value1, float value2)
        {
            return Strategy.Calc(value1, value2);
        }
    }
}
