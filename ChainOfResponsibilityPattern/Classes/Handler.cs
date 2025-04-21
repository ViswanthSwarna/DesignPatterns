using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Classes
{
    public abstract class Handler
    {
        public Handler next { get; set; }

        public Handler SetHandler(Handler handler) 
        {
            this.next = handler;
            return next;
        }
        public abstract bool Handle();
    }
}
