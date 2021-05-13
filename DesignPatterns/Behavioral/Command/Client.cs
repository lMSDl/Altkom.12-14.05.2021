using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Command
{
        public class Client
        {
            public static void Execute()
            {
                var garden = new Garden(5);
            var command1 = new PlantCommand(garden, "tree");
            var command2 = new RemoveCommand(garden, "tree");
            var command3 = new PlantCommand(garden, "flowers");
            var command4 = new RemoveCommand(garden, "flowers");

            var plantTreeButton = new CommandInvoker(command1);
            var removeTreeButton = new CommandInvoker(command2);
            var plantFlowersButton = new CommandInvoker(command3);
            var removeFlowersButton = new CommandInvoker(command4);


            Console.WriteLine(garden);

            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantFlowersButton.Invoke();

            Console.WriteLine(garden);

            removeTreeButton.Invoke();
            removeFlowersButton.Invoke();
            removeFlowersButton.Invoke();

            Console.WriteLine(garden);

            CommandInvoker.Undo();
            CommandInvoker.Undo();
            removeTreeButton.Invoke();
            Console.WriteLine(garden);
        }
        }
}