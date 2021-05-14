using System;
using System.Collections;
using System.Collections.Generic;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Iterator
{
    class BufferIterator<T> : IEnumerator<Tuple<T, T>>
    {
        private IEnumerator<T> enumerator;

        public BufferIterator(IEnumerable<T> enumerable)
        {
            enumerator = enumerable.GetEnumerator();
            Reset();
        }

        public Tuple<T, T> Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            enumerator.Dispose();
            enumerator = null;
            Current = null;
        }

        public bool MoveNext()
        {
            var buffer = enumerator.Current;
            if (enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(buffer, enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            enumerator.Reset();
            enumerator.MoveNext();
            Current = null;
        }
    }
}
