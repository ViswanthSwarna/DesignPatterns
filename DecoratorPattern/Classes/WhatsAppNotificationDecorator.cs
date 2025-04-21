using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Classes
{
    public class WhatsAppNotificationDecorator :BaseNotificationDecorator
    {
        public WhatsAppNotificationDecorator(INotifier notifier):base(notifier)
        {
        }

        public override void Notify() 
        {
            base.Notify();
            Console.WriteLine("Notification from whatsapp");
        }
    }
}
