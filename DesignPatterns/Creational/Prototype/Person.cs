using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Prototype
{
    public class Person : Base
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<string> Addresses { get; set; } = new List<string>();
        public IdInfo IdInfo { get; set; }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }
        public override object Clone()
        {
            var clone = (Person) MemberwiseClone();
            clone.Addresses = new List<string>(Addresses);
            clone.IdInfo = (IdInfo)IdInfo.Clone();
            return clone;
        }
    }
}
