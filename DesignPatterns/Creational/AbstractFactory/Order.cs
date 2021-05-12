using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    public class Order
    {
        private readonly ICar _car;

        public Order(ICarFactory manufacturer, string segment, Type type)
        {
            if(type == typeof(ISedan))
                    _car = manufacturer.ManufactureSedan(segment);
            else if(type == typeof(ISuv))
                    _car = manufacturer.ManufactureSuv(segment);
        }

        public string ManufacturedCarName()
        {
            return _car?.Name();
        }
    }
}
