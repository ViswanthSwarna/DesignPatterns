

using IteratorPattern.Classes;
using IteratorPattern.Interfaces;

ICustomCollection collection = new CustomCollection();
IIterator<List<string>> iterator = collection.GetIterator();
foreach(string i in iterator.Iterate())
{
    Console.WriteLine($"Value: {i}");
}