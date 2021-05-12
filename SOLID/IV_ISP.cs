using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.SOLID.I
{
    interface IPdfFormatter
    {
        void ToPdf();
    }
    interface IExcelFormatter
    {
        void ToExcel();
    }

    class Report : IPdfFormatter, IExcelFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Generujemy dokument excel");
        }

        public void ToPdf()
        {
            Console.WriteLine("Generujemy dokument pdf");
        }
    }

    class Poem : IPdfFormatter
    {
        public void ToPdf()
        {
            Console.WriteLine("Generujemy dokument pdf");
        }
    }
}
