using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class ObserverB : Observer<int>
    {
        public override void OnNext(int value)
        {
            if(value % 2 == 0)
                Console.WriteLine("ObserverB reaguje na powiadomienie");
        }
    }
}
