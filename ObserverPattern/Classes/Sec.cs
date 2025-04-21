using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Classes
{
    public class Sec : ISubscriber<string>
    {
        public void OnChange(string data)
        {
            Console.WriteLine($"Data Changed to {data}");
        }
    }
}
