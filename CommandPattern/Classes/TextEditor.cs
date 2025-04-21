using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    public class TextEditor
    {
        public string text { get; set; }

        public void Execute(ICommand command) 
        {
            command.execeute();
        }

        public void Undo(ICommand command)
        {
            command.undo();
        }
    }
}
