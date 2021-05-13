using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Command
{
    public class CommandInvoker
    {
        private static Stack<ICommand> commands = new Stack<ICommand>();

        ICommand command;

        public CommandInvoker(ICommand command)
        {
            this.command = command;
        }

        public void Invoke()
        {
            if(command.Execute())
                commands.Push(command);
        }

        public static void Undo()
        {
            if(commands.Any())
                commands.Pop().Undo();
        }
    }
}
