

using MediatorPattern.Classes;
using MediatorPattern.Interfaces;

Checkbox checkBox = new Checkbox();
TextBox textBox = new TextBox();
IMediator mediator = new Dialog(checkBox,textBox);
checkBox.SetMediator(mediator);
textBox.SetMediator(mediator);
textBox.SetValue("Hello");
checkBox.SetValue(true);
textBox.SetValue("Hello");