using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Observer
{
    public class Subject : IObservable<int>, IDisposable
    {
        private ICollection<IObserver<int>> _observers;
        private int index;

        public Subject(ICollection<IObserver<int>> observers)
        {
            _observers = observers;
        }
        public Subject() : this(new List<IObserver<int>>())
        {
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return new Ubsubscribe(() => _observers?.Remove(observer));
        }

        public int Index
        {
            get => index;
            set
            {
                index = value;
                Notify();
            }
        }

        public void Notify()
        {
            int index = Index;
            if (index < 0)
                _observers.ToList().ForEach(x => x.OnError(new IndexOutOfRangeException(index.ToString())));
            else
                _observers.ToList().ForEach(x => Task.Run(() => x.OnNext(index)));
        }

        public void Work()
        {
            Console.WriteLine($"Subject wykonuje obliczenia...");
            Thread.Sleep(2000);

            Index = new Random().Next(-1, 10);
            Console.WriteLine($"Subject zmienił stan na {Index}");
        }

        public void Dispose()
        {
            _observers.ToList().ForEach(x => x.OnCompleted());
        }

        public class Ubsubscribe : IDisposable
        {
            private Action action;

            public Ubsubscribe(Action action)
            {
                this.action = action;
            }

            public void Dispose()
            {
                action();
            }
        }
    }
}
