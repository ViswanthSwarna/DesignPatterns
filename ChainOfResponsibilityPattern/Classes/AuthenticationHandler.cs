using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Classes
{
    public class AuthenticationHandler : Handler
    {
        public override bool Handle()
        {
            Console.Write("Do what needed in authentication");
            if (next == null)
                return false;
            return this.next.Handle();
        }
    }
}
