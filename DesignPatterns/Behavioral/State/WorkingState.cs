using System;
using System.Threading;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.State
{
    public class WorkingState : State
    {
        private CancellationTokenSource _cancellationTokenSource;
        private readonly int _time;

        public WorkingState(int time)
        {
            _time = time;

        }

        public override void LargeCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }

        public override void SmallCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }

        protected override void Init()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            var task = Task.Delay(TimeSpan.FromSeconds(_time), _cancellationTokenSource.Token);
            task.ContinueWith(x =>
            {
                StateContext.TransitionTo(new IdleState());
                _cancellationTokenSource.Dispose();
            });
        }
    }
}
