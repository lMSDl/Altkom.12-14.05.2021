using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.PrivateClassData
{
    public class PrivateClassData
    {
        private int value1;
        private string value2;

        public PrivateClassData(int value1, string value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public int GetValue1()
        {
            return value1;
        }

        public string GetValue2()
        {
            return value2;
        }
    }
}
