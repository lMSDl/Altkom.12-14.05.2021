using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class Client
    {
        public static void Execute()
        {
            using (var subject = new Subject())
            {
                var observerA = new ObserverA();
                observerA.Subscribe(subject);

                var observerB = new ObserverB();
                observerB.Subscribe(subject);


                subject.Index = 6;
                subject.Index = 2;

                subject.Work();
                subject.Work();

                observerB.Unsubscribe();

                subject.Work();
                subject.Work();

                subject.Subscribe(observerB);
                subject.Work();
                subject.Work();
            }
        }
    }
}
