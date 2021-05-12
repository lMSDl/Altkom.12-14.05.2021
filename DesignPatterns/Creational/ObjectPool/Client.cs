using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.ObjectPool
{
    public class Client
    {
        public static void Execute()
        {
            /*var counter = 0;
            while (true)
            {
                if (counter > 1000)
                {
                    Thread.Sleep(1);
                    continue;
                }
                var item = new Item() { IsVisible = true };
                Task.Delay(1).ContinueWith(x => { item.IsVisible = false; counter--; });
                counter++;
            }*/

            /*var pool = new ObjectPool<Item>(1000, () => new Item());
            while (true)
            {
                Item item = pool.Aquire();
                if (item == null)
                {
                    Thread.Sleep(1);
                    continue;
                }
                item.IsVisible = true;
                Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; pool.Release(item); });
            }*/

            var pool = new ItemPool(1000);
            while (true)
            {
                Item item = pool.Aquire();
                if (item == null)
                {
                    Thread.Sleep(1);
                    continue;
                }
                Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; });
            }
        }
    }
}
