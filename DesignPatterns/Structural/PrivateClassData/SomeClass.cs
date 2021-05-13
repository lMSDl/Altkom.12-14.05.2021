using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.PrivateClassData
{
    public class SomeClass
    {
        //private PrivateClassData privateClassData;
        private UniversalPrivateClassData privateClassData;

        public SomeClass(int value1, string value2)
        {
            //privateClassData = new PrivateClassData(value1, value2);
            privateClassData = new UniversalPrivateClassData(
                new KeyValuePair<string, object>(nameof(value1), value1),
                new KeyValuePair<string, object>(nameof(value2), value2));
        }

        public int GetValue1()
        {
            //return privateClassData.GetValue1();
            return privateClassData.Get<int>("value1");
        }

        public string GetValue2()
        {
            //return privateClassData.GetValue2();
            return privateClassData.Get<string>("value2");
        }

        public void DoSth()
        {
            //value2 = "3";
        }

    }
}
