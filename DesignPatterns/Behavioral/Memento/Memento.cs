using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Memento
{
    public class Memento<T> where T : IRestorable<T>
    {
        private T State { get; }
        public DateTime DateTime { get; }

        public Memento(T state)
        {
            State = state;
            DateTime = DateTime.Now;
        }

        public void Restore(T originator)
        {
            originator.Restore(State);
        }
    }
}
