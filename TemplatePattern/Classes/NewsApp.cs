using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Classes
{
    public class NewsApp : AppStart
    {
        public override void Exit()
        {
            Console.WriteLine("Exit  News");
        }

        public override void Initialization()
        {
            Console.WriteLine("Initialization  News");
        }

        public override void Render()
        {
            Console.WriteLine("Render  News");
        }
    }
}
