using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Iterator
{
    public class Buffer<T> : IEnumerable<Tuple<T, T>>
    {
        private IEnumerable<T> enumerable;

        public Buffer(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }

        public IEnumerator<Tuple<T, T>> GetEnumerator()
        {
            return new BufferIterator<T>(enumerable);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
