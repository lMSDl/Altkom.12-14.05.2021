using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public abstract class BaseHandler<T>
    {
        protected T NextHandler { get; }

        public BaseHandler(T handler)
        {
            NextHandler = handler;
        }
    }
}
