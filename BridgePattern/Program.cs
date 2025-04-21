

using BridgePattern.Classes;
using BridgePattern.Interfaces;

Client client1 = new LongtermClient(new CreditCard());
Client client2= new LongtermClient(new DebitCard());
Client client3 = new ShorttermClient(new CreditCard());
Client client4 = new ShorttermClient(new DebitCard());

client1.BookOrder();
client2.BookOrder();
client3.BookOrder();
client4.BookOrder();