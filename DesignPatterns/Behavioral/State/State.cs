using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.State
{
    public abstract class State : IState
    {
        private IStateContext stateContext;

        public IStateContext StateContext
        {
            protected get => stateContext; set
            {
                stateContext = value;
                if(stateContext != null)
                    Init();
            }
        }


        public abstract void LargeCoffee();
        public abstract void SmallCoffee();

        protected abstract void Init();
    }
}
