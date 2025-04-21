

using VisitorPattern.Classes;
using VisitorPattern.Interfaces;

IClient client = new LongtermClient();
client.Accept(new EmailVisitor());