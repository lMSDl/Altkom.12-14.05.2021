using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class ObserverA : Observer<int>
    {
        public override void OnNext(int value)
        {
            Thread.Sleep(value * 1000);
            //if(value < 5)
                Console.WriteLine($"ObserverA reaguje na powiadomienie ({value})");
        }
    }
}
