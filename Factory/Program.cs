// See https://aka.ms/new-console-template for more information
using Factory;
using Factory.Inferface;

Console.WriteLine($"Hello, Select 1. Credit Card 2. Debit Card");
string input = Console.ReadLine();


PaymentTypeFactory paymentTypeFactory = new PaymentTypeFactory();
IPaymentType paymentType = paymentTypeFactory.Create(input);


paymentType.Pay();