using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Decorator
{
    public abstract class BaseDecorator : INotification
    {
        private INotification notification;

        protected BaseDecorator(INotification notification)
        {
            this.notification = notification;
        }

        public void Send(string message)
        {
            notification.Send(message);
            DecoratorSend(message);
        }

        protected abstract void DecoratorSend(string message);
    }
}
