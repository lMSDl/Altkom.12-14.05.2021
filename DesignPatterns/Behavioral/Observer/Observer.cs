using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Observer
{
    public abstract class Observer<T> : IObserver<T>
    {
        private IDisposable subscription;

        public void Subscribe(IObservable<T> observable)
        {
            subscription = observable.Subscribe(this);
        }

        public void OnCompleted()
        {
            subscription?.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name}: {error.GetType().Name}({error.Message})");
        }

        public abstract void OnNext(T value);

        public void Unsubscribe()
        {
            subscription?.Dispose();
        }
    }
}
