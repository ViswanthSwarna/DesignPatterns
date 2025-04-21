

using CommandPattern.Classes;
using CommandPattern.Interfaces;

TextEditor textEditor = new TextEditor();
ICommand commandA = new AddTextACommand(textEditor);
ICommand commandB = new AddTextBCommand(textEditor);
textEditor.Execute(commandA);
textEditor.Execute(commandA);
textEditor.Execute(commandB);
textEditor.Execute(commandB);
textEditor.Undo(commandA);
textEditor.Undo(commandB);
textEditor.Undo(commandB);
textEditor.Undo(commandA);