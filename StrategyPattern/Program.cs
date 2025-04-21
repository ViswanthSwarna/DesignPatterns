

using StrategyPattern.Classes;

PaymentProcessor paymentProcessor = new PaymentProcessor();
paymentProcessor.SetStrategy(new NetBankingStrategy());
paymentProcessor.ProcessPayment();