using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.Classes
{
    public abstract class AppStart
    {
        public abstract void Initialization();

        public abstract void Render();

        public abstract void Exit();

        public void SomeStuff() 
        {
            Console.WriteLine("Something");
        }

        public void StartCycle() 
        {
            Initialization();
            Render();
            SomeStuff();
            Exit();
        }
    }
}
