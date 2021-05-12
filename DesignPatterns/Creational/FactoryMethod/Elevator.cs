using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.FactoryMethod
{
    public class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public Elevator()
        {
            var type = typeof(IElevatorOperation);
            _operations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));

           /* _operations = new Dictionary<string, IElevatorOperation>
            {
            { "Up", new ElevatorUp() },
            { "Down", new ElevatorDown() }
            };*/
        }

        public void Execute(IElevatorOperation operation, int floor)
        {
            operation?.Operate(floor);
        }

        public void Execute(string action, int floor)
        {
            var operation = CreateOperation(action);
            Execute(operation, floor);
        }

        public IElevatorOperation CreateOperation(string action)
        {
            if(_operations.TryGetValue(action, out var operation))
            {
                return operation;
            }

            IElevatorOperation elevatorOperation = null;
            switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    elevatorOperation = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    elevatorOperation = new ElevatorUp();
                    break;
            }

            if (elevatorOperation != null)
                _operations[action] = elevatorOperation;

            return elevatorOperation;
        }
    }
}
