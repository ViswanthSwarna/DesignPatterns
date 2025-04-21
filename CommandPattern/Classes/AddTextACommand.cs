using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    public class AddTextACommand : ICommand
    {
        public TextEditor textEditor;
        public AddTextACommand(TextEditor textEditor)
        {
            this.textEditor = textEditor;
        }
        public void execeute()
        {
            textEditor.text = textEditor.text + "A";
            Console.WriteLine($"text: {textEditor.text}");
        }

        public void undo()
        {
            var charArray = textEditor.text.ToCharArray();
            if(charArray[textEditor.text.Length-1] == 'A') 
            {
                textEditor.text = textEditor.text.Substring(0, textEditor.text.Length - 1);
                Console.WriteLine($"text: {textEditor.text}");
            }
            else 
            {
                Console.WriteLine("Something Changed undo not possible");
            }
        }
    }
}
