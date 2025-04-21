using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Classes
{
    public class Dialog : IMediator
    {
        private readonly Checkbox checkBox;
        private readonly TextBox textBox;
        public Dialog(Checkbox checkBox, TextBox textBox)
        {
            this.checkBox = checkBox;
            this.textBox = textBox;
        }
        public void OnChangeCheckBox(bool value)
        {
            textBox.SetEnabled(value);
        }
    }
}
