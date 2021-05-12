using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    public interface ICar
    {
        string Name();
    }

    public interface ISedan : ICar
    {

    }

    public interface ISuv : ICar
    {

    }
    public interface ICarFactory
    {
        ISedan ManufactureSedan(string segment);
        ISuv ManufactureSuv(string segment);
    }

}
