using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Classes
{
    public class FitnessApp : AppStart
    {
        public override void Exit()
        {
            Console.WriteLine("Exit Fitness");
        }

        public override void Initialization()
        {
            Console.WriteLine("Initialization Fitness");
        }

        public override void Render()
        {
            Console.WriteLine("Render Fitness");
        }
    }
}
