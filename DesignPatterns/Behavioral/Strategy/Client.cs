using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Strategy
{
    public class Client
    {
        public static void Execute()
        {
            var calc = new Calculator();

            while (true)
            {
                var line = Console.ReadLine();

                var split = line.Split(' ');
                if (split.Length < 3)
                    continue;

                calc.Strategy = GetCalcStrategy(split[1]);

                if (float.TryParse(split[0], out float val1) &&
                    float.TryParse(split[2], out float val2))
                {
                    var result = calc.Calculate(val1, val2);
                    Console.WriteLine(result);
                    result = GetFunc(split[1])(val1, val2);
                    Console.WriteLine(result);
                    result = calc.Calculate(GetFunc(split[1]), val1, val2);
                    Console.WriteLine(result);
                }

            }
        }

        private static ICalcStrategy GetCalcStrategy(string arg)
        {
            switch (arg)
            {
                case "*":
                    return new MultiplyStrategy();
                case "/":
                    return new DivideStrategy();
                case "+":
                    return new PlusStrategy();
                case "-":
                    return new MinusStrategy();
                default:
                    return null;
            }
        }

        private static Func<float, float, float> GetFunc(string arg)
        {
            switch (arg)
            {
                case "*":
                    return (a, b) => a * b;
                case "/":
                    return (a, b) => a / b;
                case "+":
                    return (a, b) => a + b;
                case "-":
                    return (a, b) => a - b;
                default:
                    return null;
            }
        }
    }
}
