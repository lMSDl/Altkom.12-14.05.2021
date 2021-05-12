﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.ObjectPool
{
    public class ItemPool
    {
        public ItemPool(int numberOfItems)
        {
            _items = Enumerable.Range(1, numberOfItems).Select(x => new Item()).ToList();
        }


        private IReadOnlyCollection<Item> _items;


        public Item Aquire()
        {
            lock (_items)
            {
                var item = _items.FirstOrDefault(x => !x.IsVisible);
                if (item != null)
                    item.IsVisible = true;
                return item;
            }
        }

    }
}
