

using AbstractFactoryPattern;
using AbstractFactoryPattern.Interface;

IBank bank = BankFactory.CreateFactory("HDFC");
bank.CreateCreditCard().Pay();