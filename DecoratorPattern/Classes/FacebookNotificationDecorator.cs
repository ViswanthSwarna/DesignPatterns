using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Classes
{
    public class FacebookNotificationDecorator : BaseNotificationDecorator
    {
        public FacebookNotificationDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Notify() 
        {
            base.Notify();
            Console.WriteLine("Notification from facebook");
        }
    }
}
