

using MementoPattern.Classes;

Bank bank = new Bank();
bank.SetAccountNumber("Hello");
bank.SetName("Sai");
bank.SetPanCard("GXPP");
bank.SetPhoneNumber("999");
bank.SetEmailId("VIS@gmial.com");
Memento m1 = bank.CreateSnapshot();
bank.SetAccountNumber("XYZ");
bank.SetName("Vish");
bank.SetPanCard("ZYYY");
bank.SetPhoneNumber("888");
bank.SetEmailId("hello@gmial.com");
Memento m2 = bank.CreateSnapshot();
bank.CreateAccount();
bank.RestoreSnapshot(m1);
bank.CreateAccount();
bank.RestoreSnapshot(m2);
bank.CreateAccount();