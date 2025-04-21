using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Classes
{
    public class TextBox : IComponent
    {
        private IMediator mediator;
        private string value;
        private bool enabled;
        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetValue(string value)
        {
            if (enabled)
            {
                this.value = value;
                Console.WriteLine($"TextBox value: {value}");
            }
            else
            {
                Console.WriteLine("TextBox is disabled");
            }
        }

        public void SetEnabled(bool value)
        {
            enabled = value;
        }
    }
}
