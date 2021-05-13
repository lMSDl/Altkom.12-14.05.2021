using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.PrivateClassData
{
    public class UniversalPrivateClassData
    {
        public Dictionary<string, object> data;

        public UniversalPrivateClassData(params KeyValuePair<string, object>[] valuePair)
        {
            data = valuePair.ToDictionary(x => x.Key, x => x.Value);
        }

        public T Get<T>(string name)
        {
            return (T)data[name];
        }
    }
}
