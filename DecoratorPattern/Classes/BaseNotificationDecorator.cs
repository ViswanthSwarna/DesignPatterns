using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Classes
{
    public abstract class BaseNotificationDecorator : INotifier
    {
        private readonly INotifier notifier;
        public BaseNotificationDecorator(INotifier notifier)
        {
            this.notifier = notifier;
        }
        public virtual void Notify()
        {
            notifier.Notify();
        }
    }
}
