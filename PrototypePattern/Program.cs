

using PrototypePattern.Classes;
using PrototypePattern.Interface;

Bank bank = new Bank("HDFC", "Koramangala");

Bank bank2 = (Bank)bank.Clone();
bank2.bankName = "ICICI";

bank.PrintDetails();
bank2.PrintDetails();
