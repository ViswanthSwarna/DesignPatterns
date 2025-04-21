using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Classes
{
    public class ShortTermClient : IClient
    {
        public void Initialize()
        {
            Console.WriteLine("Initialize Shortterm Client");
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
