using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Command
{
    public class RemoveCommand : ICommand
    {
        private Garden _garden;
        private string plant;

        public RemoveCommand(Garden garden, string plant)
        {
            _garden = garden;
            this.plant = plant;
        }

        public bool Execute()
        {
            return _garden.Remove(plant);
        }

        public bool Undo()
        {
            return _garden.Plant(plant);
        }
    }
}
