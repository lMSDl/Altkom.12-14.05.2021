using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.NullObject
{
    public class Client
    {
        public static Output Output { get; set; }
        public static void Execute()
        {
            while (true)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'c':
                        Output = new ConsoleOutput();
                        break;
                    case 'd':
                        Output = new DebugOutput();
                        break;
                    default:
                        Output = new NullOutput();
                        break;
                }

                Console.WriteLine();
                //if(Output != null)
                    Output.Show(Console.ReadLine());
            }
        }
    }
}
