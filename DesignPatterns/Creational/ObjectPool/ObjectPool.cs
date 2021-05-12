using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.ObjectPool
{
    public class ObjectPool<T>
    {
        public ObjectPool(int numberOfItems, Func<T> func)
        {
            _free = Enumerable.Range(1, numberOfItems).Select(x => func()).ToList();
        }


        private List<T> _free;
        private List<T> _taken = new List<T>();


        public T Aquire()
        {
            lock(_free)
            {
                var item = _free.FirstOrDefault();
                _free.Remove(item);
                if(item != null)
                    _taken.Add(item);
                return item;
            }
        }

        public void Release(T item)
        {
            lock (_free)
            {
                _taken.Remove(item);
                _free.Add(item);
            }
        }

    }
}
