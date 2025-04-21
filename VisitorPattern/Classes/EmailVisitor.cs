using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Classes
{
    public class EmailVisitor : IVisitor
    {
        public void Visit(LongtermClient client)
        {
            Console.WriteLine("Email LongTerm");
        }

        public void Visit(ShortTermClient client)
        {
            Console.WriteLine("Email Shortterm");
        }
    }
}
