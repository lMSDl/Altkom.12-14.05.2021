using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Prototype
{
    public class IdInfo : Base
    {
        public Guid IdNumber { get; set; }

        public IdInfo()
        {
            IdNumber = Guid.NewGuid();
        }
    }
}
