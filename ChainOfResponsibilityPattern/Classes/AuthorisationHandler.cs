using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Classes
{
    public class AuthorisationHandler : Handler
    {
        public override bool Handle()
        {
            Console.Write("Do what needed in authrisation");
            if (next == null)
                return false;
            return this.next.Handle();
        }
    }
}
