using System;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.State
{
    public class IdleState : State
    {
        public override void LargeCoffee()
        {
            Console.WriteLine("IdleState: make large coffee");
            StateContext.TransitionTo(new WorkingState(8));
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("IdleState: make small coffee");
            StateContext.TransitionTo(new WorkingState(5));
        }

        protected override void Init()
        {
        }
    }
}