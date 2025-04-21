using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Logging
    {
        private static Logging _instance;
        private static readonly object _lock = new object();

        private Logging()
        {

        }

        public static Logging getInstance() 
        {
            if(_instance == null) 
            {
                lock (_lock) 
                {
                    if(_instance == null) 
                    {
                        _instance = new Logging();
                    }   
                }
                
            }
            return _instance;
        }

        public void Log(string message) 
        {
            Console.WriteLine(message);
        }
    }
}
