using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Classes
{
    public class MiddlewareHandler : Handler
    {
        public override bool Handle()
        {
            Console.Write("Do what needed in middleware");
            if (next == null)
                return false;
            return this.next.Handle();
        }
    }
}
