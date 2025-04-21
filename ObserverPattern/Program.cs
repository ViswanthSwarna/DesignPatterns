

using ObserverPattern.Classes;
using ObserverPattern.Interfaces;

IPublisher<string> bank = new BankData();
ISubscriber<string> sec = new Sec();
bank.Subscribe(sec);
bank.SetData("Hello 1");
bank.SetData("Hello 2");
bank.SetData("Hello 3");
bank.SetData("Hello 4");
bank.SetData("Hello 5");
bank.UnSubscribe(sec);
bank.SetData("Hello");