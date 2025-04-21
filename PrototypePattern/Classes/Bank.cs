using PrototypePattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Classes
{
    public class Bank : IClonable
    {
        public string bankName { set; get; }
        private string location;
        public Bank(string bankName, string location)
        {
            this.bankName = bankName;
            this.location = location;
        }


        public void PrintDetails() 
        {
            Console.WriteLine($"Bank Name: {bankName}");
            Console.WriteLine($"Location: {location}");
        }
        public object Clone()
        {
            return new Bank(this.bankName, this.location);
        }
    }
}
