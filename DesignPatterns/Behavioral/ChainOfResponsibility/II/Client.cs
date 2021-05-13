using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Client
    {
        public static void Execute()
        {
            var frame = new Frame();

            var textBox = new TextBox();
            frame.Add(textBox);

            var button = new Button();
            textBox.Add(button);

            button.Func = () =>
            {
                if (string.IsNullOrEmpty(textBox.InputText))
                {
                    return false;
                }
                textBox.InputText = null;
                Console.WriteLine("TextBox clear");
                return true;
            };

            button.Click();
            textBox.InputText = "abc";
            Console.WriteLine(textBox.InputText);
            textBox.Click();
            button.Click();
            button.Click();

        }
    }
}
