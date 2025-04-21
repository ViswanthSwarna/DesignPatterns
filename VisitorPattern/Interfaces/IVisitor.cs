using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Classes;

namespace VisitorPattern.Interfaces
{
    public interface IVisitor
    {
        void Visit(LongtermClient client);

        void Visit(ShortTermClient client);
    }
}
