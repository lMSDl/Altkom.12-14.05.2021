using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.State
{
    public class CoffeeMachine : IStateContext
    {
        private IState _state;

        public CoffeeMachine()
        {
            _state = new HeatingUpState();
            _state.StateContext = this;
        }

        public void ButtonLargeCoffee()
        {
            _state.LargeCoffee();
        }
        public void ButtonSmallCoffee()
        {
            _state.SmallCoffee();
        }

        public void TransitionTo(IState state)
        {
            Console.WriteLine($"Zmiana stanu: {_state.GetType().Name} => {state.GetType().Name}");
            _state.StateContext = null;
            _state = state;
            _state.StateContext = this;
        }
    }
}
