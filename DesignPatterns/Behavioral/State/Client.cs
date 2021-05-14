using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.State
{
    public class Client
    {
        public static void Execute()
        {
            var coffeeMachine = new CoffeeMachine();

            Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith(x => coffeeMachine.ButtonLargeCoffee());
            Task.Delay(TimeSpan.FromSeconds(3)).ContinueWith(x => coffeeMachine.ButtonSmallCoffee());

            Task.Delay(TimeSpan.FromSeconds(7)).ContinueWith(x => coffeeMachine.ButtonLargeCoffee());
            Task.Delay(TimeSpan.FromSeconds(9)).ContinueWith(x => coffeeMachine.ButtonSmallCoffee());

            Task.Delay(TimeSpan.FromSeconds(12)).ContinueWith(x => coffeeMachine.ButtonSmallCoffee());
            Task.Delay(TimeSpan.FromSeconds(20)).ContinueWith(x => coffeeMachine.ButtonLargeCoffee());

        }
    }
}